using Backend_App.Application.DTO;
using Backend_App.DataModel.Repository;
 
namespace Backend_App.Application.Services;
 
public interface IEntriesService
{
    Task<PagedResultDto<ClassificationEntryDto>> GetEntriesAsync(EntriesFilterDto filter);
    Task<List<string>> GetCountriesAsync();
    Task<List<SportSummaryDto>> GetSportsAsync();
}