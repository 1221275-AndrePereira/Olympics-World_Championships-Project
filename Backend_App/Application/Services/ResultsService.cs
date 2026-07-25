using Backend_App.Application.DTO;
using Backend_App.DataModel.Repository;
 
namespace Backend_App.Application.Services;
 
/// 
/// Business logic for the Results Browser feature (season/year/sport/event drill-down,
/// medal tables, country medalist lists). Pulls raw data from IClassificationRepository
/// and applies domain rules on top - sorting, medal tallying, search filtering.
/// 
public class ResultsService : IResultsService
{
    // This workbook only covers two specific Games, so season maps 1:1 to a year.
    // If more Games were ever added to the source data, this is the one place to extend.
    private static readonly Dictionary<string, int> SeasonYearMap = new(StringComparer.OrdinalIgnoreCase)
    {
        ["Summer"] = 2024,
        ["Winter"] = 2026  
    };
 
    private readonly IClassificationRepository _repo;
    private readonly ICountrySummaryRepository _countrySummaryRepo;
 
    public ResultsService(IClassificationRepository repo, ICountrySummaryRepository countrySummaryRepo)
    {
        _repo = repo;
        _countrySummaryRepo = countrySummaryRepo;
    }
 
    public Task<List<string>> GetSeasonsAsync() =>
        Task.FromResult(SeasonYearMap.Keys.ToList());
 
    public Task<List<int>> GetYearsAsync(string season) =>
        Task.FromResult(SeasonYearMap.TryGetValue(season, out var year) ? new List<int> { year } : new List<int>());
 
    public async Task<List<string>> GetSportsAsync(string season)
    {
        var sheets = await _repo.GetSportSheetsAsync();
        return sheets.Where(s => s.Season.Equals(season, StringComparison.OrdinalIgnoreCase))
                     .Select(s => s.Sport).Distinct().OrderBy(s => s).ToList();
    }
 
    public async Task<List<OptionDto>> GetEventsAsync(string season, string sport)
    {
        var pairs = await _repo.GetEventOptionsAsync(season, sport);
        return pairs.Select(p => new OptionDto
        {
            Key = BuildEventKey(p.Category, p.Event),
            Label = $"{p.Category} \u2013 {p.Event}"
        }).ToList();
    }
 
    public async Task<List<ResultRowDto>> GetResultsAsync(
        string season, string sport, string eventKey,
        string? athleteSearch, string? countrySearch, string sortBy)
    {
        var (category, ev) = ParseEventKey(eventKey);
        var entries = await _repo.GetEntriesForEventAsync(season, sport, category, ev);
 
        var rows = entries.Select(e => new ResultRowDto
        {
            Rank = e.ClassificationValue ?? -1,
            IsPending = e.IsPending,
            Athlete = string.IsNullOrWhiteSpace(e.EntryName) ? e.Country : e.EntryName!,
            Country = e.Country
        }).AsEnumerable();
 
        if (!string.IsNullOrWhiteSpace(athleteSearch))
            rows = rows.Where(r => r.Athlete.Contains(athleteSearch, StringComparison.OrdinalIgnoreCase));
        if (!string.IsNullOrWhiteSpace(countrySearch))
            rows = rows.Where(r => r.Country.Contains(countrySearch, StringComparison.OrdinalIgnoreCase));
 
        rows = sortBy switch
        {
            "athlete" => rows.OrderBy(r => r.Athlete, StringComparer.OrdinalIgnoreCase),
            "country" => rows.OrderBy(r => r.Country, StringComparer.OrdinalIgnoreCase),
            _ => rows.OrderBy(r => r.IsPending).ThenBy(r => r.Rank)
        };
 
        return rows.ToList();
    }
 
    public async Task<List<MedalTallyDto>> GetMedalTableAsync(string season, int year)
    {
        // Single-Games dataset: the year is validated against the season's mapped year,
        // but the underlying query is the same as the season-wide medal set.
        if (!SeasonYearMap.TryGetValue(season, out var mappedYear) || mappedYear != year)
            return new List<MedalTallyDto>();
 
        var entries = await _repo.GetMedalEntriesAsync(season);
        return TallyMedals(entries.Select(e => (e.Country, e.ClassificationValue!.Value)));
    }
 
    public async Task<List<MedalTallyDto>> GetAllTimeMedalTableAsync(string season)
    {
        // Unlike GetMedalTableAsync (this specific Games' standings, built from live
        // classification data), this uses the country summary sheet's real historical
        // medal counts for the season - i.e. every past Summer or Winter Games combined.
        var summaries = await _countrySummaryRepo.GetAllAsync();
        var isSummer = season.Equals("Summer", StringComparison.OrdinalIgnoreCase);
 
        return summaries
            .Select(s => new MedalTallyDto
            {
                Country = s.Country,
                Gold = isSummer ? s.SummerGoldMedals : s.WinterGoldMedals,
                Silver = isSummer ? s.SummerSilverMedals : s.WinterSilverMedals,
                Bronze = isSummer ? s.SummerBronzeMedals : s.WinterBronzeMedals,
                Total = isSummer ? s.SummerTotalMedals : s.WinterTotalMedals
            })
            .Where(m => m.Total > 0)
            .OrderByDescending(m => m.Gold).ThenByDescending(m => m.Silver).ThenByDescending(m => m.Bronze)
            .ToList();
    }
 
    public async Task<List<CountryMedalDto>> GetCountryMedalistsAsync(
        string season, int year, string country, string? athleteSearch, string sortBy)
    {
        if (!SeasonYearMap.TryGetValue(season, out var mappedYear) || mappedYear != year)
            return new List<CountryMedalDto>();
 
        var entries = await _repo.GetMedalEntriesForCountryAsync(season, country);
        return ProjectAndSortMedalists(entries, mappedYear, athleteSearch, sortBy);
    }
 
    public async Task<List<CountryMedalDto>> GetAllTimeCountryMedalistsAsync(
        string season, string country, string? athleteSearch, string sortBy)
    {
        var entries = await _repo.GetMedalEntriesForCountryAsync(season, country);
        var year = SeasonYearMap.GetValueOrDefault(season, 0);
        return ProjectAndSortMedalists(entries, year, athleteSearch, sortBy);
    }
 
    // --- helpers ---------------------------------------------------------
 
    private static string BuildEventKey(string category, string @event) => $"{category}||{@event}";
 
    private static (string Category, string Event) ParseEventKey(string eventKey)
    {
        var parts = eventKey.Split("||", 2);
        return parts.Length == 2 ? (parts[0], parts[1]) : ("", eventKey);
    }
 
    private static List<MedalTallyDto> TallyMedals(IEnumerable<(string Country, int Rank)> medalHits)
    {
        return medalHits
            .GroupBy(m => m.Country)
            .Select(g => new MedalTallyDto
            {
                Country = g.Key,
                Gold = g.Count(m => m.Rank == 1),
                Silver = g.Count(m => m.Rank == 2),
                Bronze = g.Count(m => m.Rank == 3),
                Total = g.Count()
            })
            .OrderByDescending(m => m.Gold)
            .ThenByDescending(m => m.Silver)
            .ThenByDescending(m => m.Bronze)
            .ToList();
    }
 
    private static List<CountryMedalDto> ProjectAndSortMedalists(
        List<Models.ClassificationEntry> entries, int year, string? athleteSearch, string sortBy)
    {
        var medalists = entries.Select(e => new CountryMedalDto
        {
            Year = year,
            Sport = e.SportSheet!.Sport,
            Category = e.SportSheet.Category,
            Event = e.Event,
            Athlete = string.IsNullOrWhiteSpace(e.EntryName) ? e.Country : e.EntryName!,
            Rank = e.ClassificationValue!.Value,
            Country = e.Country
        }).AsEnumerable();
 
        if (!string.IsNullOrWhiteSpace(athleteSearch))
            medalists = medalists.Where(m => m.Athlete.Contains(athleteSearch, StringComparison.OrdinalIgnoreCase));
 
        medalists = sortBy switch
        {
            "athlete" => medalists.OrderBy(m => m.Athlete, StringComparer.OrdinalIgnoreCase),
            "country" => medalists.OrderBy(m => m.Country, StringComparer.OrdinalIgnoreCase),
            _ => medalists.OrderBy(m => m.Rank)
        };
 
        return medalists.ToList();
    }
}