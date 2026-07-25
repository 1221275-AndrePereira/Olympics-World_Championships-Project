using Backend_App.Application.DTO;
using Backend_App.DataModel.Repository;
 
namespace Backend_App.Application.Services;
 
public class EntriesService : IEntriesService
{
    private readonly IClassificationRepository _repo;
    public EntriesService(IClassificationRepository repo) => _repo = repo;
 
    public async Task<PagedResultDto<ClassificationEntryDto>> GetEntriesAsync(EntriesFilterDto filter)
    {
        var pageSize = Math.Clamp(filter.PageSize, 1, 200);
        var page = Math.Max(filter.Page, 1);
 
        var (items, total) = await _repo.QueryAsync(
            filter.Sport, filter.Category, filter.Country, filter.Search, filter.PendingOnly, page, pageSize);
 
        return new PagedResultDto<ClassificationEntryDto>
        {
            Page = page,
            PageSize = pageSize,
            TotalItems = total,
            TotalPages = (int)Math.Ceiling(total / (double)pageSize),
            Items = items.Select(e => new ClassificationEntryDto
            {
                Id = e.Id,
                Sport = e.SportSheet!.Sport,
                Category = e.SportSheet.Category,
                Season = e.SportSheet.Season,
                Country = e.Country,
                Event = e.Event,
                EntryName = e.EntryName,
                ClassificationValue = e.ClassificationValue,
                IsPending = e.IsPending
            }).ToList()
        };
    }
 
    public Task<List<string>> GetCountriesAsync() => _repo.GetDistinctCountriesAsync();
 
    public async Task<List<SportSummaryDto>> GetSportsAsync()
    {
        var sheets = await _repo.GetSportSheetsAsync();
        return sheets
            .GroupBy(s => s.Sport)
            .Select(g => new SportSummaryDto
            {
                Sport = g.Key,
                Season = g.First().Season,
                Categories = g.Select(x => x.Category).Distinct().OrderBy(x => x).ToList()
            })
            .OrderBy(s => s.Sport)
            .ToList();
    }
}