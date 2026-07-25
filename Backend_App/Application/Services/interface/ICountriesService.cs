using Backend_App.Application.DTO;
using Backend_App.DataModel.Repository;
 
namespace Backend_App.Application.Services;
 
public interface ICountriesService
{
    Task<List<CountrySummaryDto>> GetSummariesAsync();
    Task<List<CountrySportQuotaDto>?> GetQuotasForCountryAsync(string country);
}