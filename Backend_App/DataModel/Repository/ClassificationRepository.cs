using Microsoft.EntityFrameworkCore;
using Backend_App.Domain.Model;
using Backend_App.DataModel.Model;
 
namespace Backend_App.DataModel.Repository;
 
public class ClassificationRepository : IClassificationRepository
{
    private readonly AppDbContext _db;
    public ClassificationRepository(AppDbContext db) => _db = db;
 
    public async Task<List<SportSheet>> GetSportSheetsAsync() =>
        await _db.SportSheets.AsNoTracking().ToListAsync();
 
    public async Task<List<string>> GetDistinctCountriesAsync() =>
        await _db.ClassificationEntries.AsNoTracking()
            .Select(e => e.Country).Distinct().OrderBy(c => c).ToListAsync();
 
    public async Task<List<(string Category, string Event)>> GetEventOptionsAsync(string season, string sport)
    {
        var pairs = await _db.ClassificationEntries.AsNoTracking()
            .Include(e => e.SportSheet)
            .Where(e => e.SportSheet!.Season == season && e.SportSheet.Sport == sport)
            .Select(e => new { e.SportSheet!.Category, e.Event })
            .Distinct()
            .OrderBy(e => e.Category).ThenBy(e => e.Event)
            .ToListAsync();
 
        return pairs.Select(p => (p.Category, p.Event)).ToList();
    }
 
    public async Task<List<ClassificationEntry>> GetEntriesForEventAsync(string season, string sport, string category, string @event) =>
        await _db.ClassificationEntries.AsNoTracking()
            .Include(e => e.SportSheet)
            .Where(e => e.SportSheet!.Season == season
                     && e.SportSheet.Sport == sport
                     && e.SportSheet.Category == category
                     && e.Event == @event)
            .ToListAsync();
 
    public async Task<List<ClassificationEntry>> GetMedalEntriesAsync(string season) =>
        await _db.ClassificationEntries.AsNoTracking()
            .Include(e => e.SportSheet)
            .Where(e => e.SportSheet!.Season == season
                     && e.ClassificationValue != null
                     && e.ClassificationValue >= 1 && e.ClassificationValue <= 3)
            .ToListAsync();
 
    public async Task<List<ClassificationEntry>> GetMedalEntriesForCountryAsync(string season, string country) =>
        await _db.ClassificationEntries.AsNoTracking()
            .Include(e => e.SportSheet)
            .Where(e => e.SportSheet!.Season == season
                     && e.Country == country
                     && e.ClassificationValue != null
                     && e.ClassificationValue >= 1 && e.ClassificationValue <= 3)
            .ToListAsync();
 
    public async Task<(List<ClassificationEntry> Items, int TotalCount)> QueryAsync(
        string? sport, string? category, string? country, string? search, bool? pendingOnly,
        int page, int pageSize)
    {
        var query = _db.ClassificationEntries.AsNoTracking().Include(e => e.SportSheet).AsQueryable();
 
        if (!string.IsNullOrWhiteSpace(sport))
            query = query.Where(e => e.SportSheet!.Sport == sport);
        if (!string.IsNullOrWhiteSpace(category))
            query = query.Where(e => e.SportSheet!.Category == category);
        if (!string.IsNullOrWhiteSpace(country))
            query = query.Where(e => e.Country == country);
        if (pendingOnly == true)
            query = query.Where(e => e.ClassificationValue == -1);
        if (!string.IsNullOrWhiteSpace(search))
        {
            var s = search.Trim();
            query = query.Where(e =>
                e.Country.Contains(s) ||
                e.Event.Contains(s) ||
                (e.EntryName != null && e.EntryName.Contains(s)) ||
                e.SportSheet!.Sport.Contains(s));
        }
 
        var total = await query.CountAsync();
 
        var items = await query
            .OrderBy(e => e.SportSheet!.Sport).ThenBy(e => e.Country).ThenBy(e => e.Event)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
 
        return (items, total);
    }
}