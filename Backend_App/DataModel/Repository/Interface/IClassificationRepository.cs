using Backend_App.DataModel.Model;
 
namespace Backend_App.DataModel.Repository;
 
/// 
/// Data-access boundary for SportSheet/ClassificationEntry data. Every method here
/// talks to the database directly (via EF Core) and returns plain entities/values -
/// no business logic (medal tallying, filtering rules, etc.) lives here. That belongs
/// in the Services layer.
/// 
public interface IClassificationRepository
{
    Task<List<SportSheet>> GetSportSheetsAsync();
    Task<List<string>> GetDistinctCountriesAsync();
 
    /// Distinct (Category, Event) pairs available for a sport within a season.
    Task<List<(string Category, string Event)>> GetEventOptionsAsync(string season, string sport);
 
    /// All entries for a given season + sport + category + event.
    Task<List<ClassificationEntry>> GetEntriesForEventAsync(string season, string sport, string category, string @event);
 
    /// All entries for a season that currently hold a medal-position value (1, 2 or 3).
    Task<List<ClassificationEntry>> GetMedalEntriesAsync(string season);
 
    /// All medal-position entries for a season, for one specific country.
    Task<List<ClassificationEntry>> GetMedalEntriesForCountryAsync(string season, string country);
 
    /// Generic filterable/paginated query used by the quota board.
    Task<(List<ClassificationEntry> Items, int TotalCount)> QueryAsync(
        string? sport, string? category, string? country, string? search, bool? pendingOnly,
        int page, int pageSize);
}