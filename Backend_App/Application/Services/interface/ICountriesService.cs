using Backend_App.Application.DTO;
 
namespace Backend_App.Application.Services;
 
public interface ICountriesService
{
    Task<List<CountrySummaryDto>> GetSummariesAsync();
    Task<List<CountrySportQuotaDto>?> GetQuotasForCountryAsync(string country);
}