using Backend_App.DataModel.Model;
 
namespace Backend_App.DataModel.Repository;
 
public interface ICountrySummaryRepository
{
    Task<List<CountrySummary>> GetAllAsync();
    Task<List<CountrySportQuota>> GetQuotasForCountryAsync(string country);
}