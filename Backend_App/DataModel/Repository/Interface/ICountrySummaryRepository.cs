using Backend_App.Domain.Model;
 
namespace Backend_App.DataModel.Repository;
 
public interface ICountrySummaryRepository
{
    Task<List<CountrySummary>> GetAllAsync();
    Task<List<CountrySportQuota>> GetQuotasForCountryAsync(string country);
}