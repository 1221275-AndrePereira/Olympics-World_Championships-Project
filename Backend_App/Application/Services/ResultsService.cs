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
    // Initially the project covered two Games; maintain a mapping but allow multiple years per season.
    private static readonly Dictionary<string, List<int>> SeasonYears = new(StringComparer.OrdinalIgnoreCase)
    {
        ["Summer"] = new List<int> { 2024,2028 },
        ["Winter"] = new List<int> { 2026,2030 }
    };
 
    private readonly IClassificationRepository _repo;
 
    public ResultsService(IClassificationRepository repo, ICountrySummaryRepository countrySummaryRepo)
    {
        _repo = repo;
    }
 
    public async Task<List<string>> GetSeasonsAsync()
    {
        var sheets = await _repo.GetSportSheetsAsync();
        var seasons = sheets.Select(s => s.Season).Distinct(StringComparer.OrdinalIgnoreCase).OrderBy(s => s).ToList();
        if (seasons.Any()) return seasons;
        return SeasonYears.Keys.ToList();
    }

    public async Task<List<int>> GetYearsAsync(string season)
    {
        var sheets = await _repo.GetSportSheetsAsync();
        var years = sheets.Where(s => s.Season.Equals(season, StringComparison.OrdinalIgnoreCase) && s.Year > 0)
                          .Select(s => s.Year).Distinct().OrderByDescending(y => y).ToList();
        if (years.Any()) return years;
        return SeasonYears.TryGetValue(season, out var known) ? known : new List<int>();
    }
 
    public async Task<List<string>> GetSportsAsync(string season, int year)
    {
        var sheets = await _repo.GetSportSheetsAsync();
        return sheets.Where(s => s.Season.Equals(season, StringComparison.OrdinalIgnoreCase) && s.Year == year)
                     .Select(s => s.Sport).Distinct().OrderBy(s => s).ToList();
    }
 
    public async Task<List<OptionDto>> GetEventsAsync(string season, int year, string sport)
    {
        var pairs = await _repo.GetEventOptionsAsync(season, sport, year);
        return pairs.Select(p => new OptionDto
        {
            Key = BuildEventKey(p.Category, p.Event),
            Label = $"{p.Category} \u2013 {p.Event}"
        }).ToList();
    }
 
    public async Task<List<ResultRowDto>> GetResultsAsync(
        string season, int year, string sport, string eventKey,
        string? athleteSearch, string? countrySearch, string sortBy)
    {
        var (category, ev) = ParseEventKey(eventKey);
        var entries = await _repo.GetEntriesForEventAsync(season, year, sport, category, ev);
 
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
        var entries = await _repo.GetMedalEntriesAsync(season, year);
        return TallyMedals(entries.Select(e => (e.Country, e.ClassificationValue!.Value)));
    }
 
    public async Task<List<MedalTallyDto>> GetAllTimeMedalTableAsync(string season)
    {
        var entries = await _repo.GetMedalEntriesAsync(season);
        return TallyMedals(entries.Select(e => (e.Country, e.ClassificationValue!.Value)));
    }
 
    public async Task<List<CountryMedalDto>> GetCountryMedalistsAsync(
        string season, int year, string country, string? athleteSearch, string? yearSearch, string sortBy)
    {
        if (!SeasonYears.TryGetValue(season, out var known) || !known.Contains(year))
            return new List<CountryMedalDto>();

        var entries = await _repo.GetMedalEntriesForCountryAsync(season, country, year);
        return ProjectAndSortMedalists(entries, year, athleteSearch, yearSearch, sortBy, useEntryYear: false);
    }
 
    public async Task<List<CountryMedalDto>> GetAllTimeCountryMedalistsAsync(
        string season, string country, string? athleteSearch, string? yearSearch, string sortBy)
    {
        var entries = await _repo.GetMedalEntriesForCountryAsync(season, country);
        return ProjectAndSortMedalists(entries, 0, athleteSearch, yearSearch, sortBy, useEntryYear: true);
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
        List<Backend_App.Domain.Model.ClassificationEntry> entries, int year, string? athleteSearch, string? yearSearch, string sortBy, bool useEntryYear)
    {
        var medalists = entries.Select(e => new CountryMedalDto
        {
            Year = useEntryYear ? e.SportSheet!.Year : year,
            Sport = e.SportSheet!.Sport,
            Category = e.SportSheet.Category,
            Event = e.Event,
            Athlete = string.IsNullOrWhiteSpace(e.EntryName) ? e.Country : e.EntryName!,
            Rank = e.ClassificationValue!.Value,
            Country = e.Country
        }).AsEnumerable();
 
        if (!string.IsNullOrWhiteSpace(athleteSearch))
            medalists = medalists.Where(m => m.Athlete.Contains(athleteSearch, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(yearSearch))
            medalists = medalists.Where(m => m.Year.ToString().Contains(yearSearch, StringComparison.OrdinalIgnoreCase));
 
        medalists = sortBy switch
        {
            "athlete" => medalists.OrderBy(m => m.Athlete, StringComparer.OrdinalIgnoreCase),
            "country" => medalists.OrderBy(m => m.Country, StringComparer.OrdinalIgnoreCase),
            "year" => medalists.OrderByDescending(m => m.Year).ThenBy(m => m.Rank),
            _ => medalists.OrderBy(m => m.Rank)
        };
 
        return medalists.ToList();
    }
}