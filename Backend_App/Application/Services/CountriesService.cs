using Backend_App.Application.DTO;
using Backend_App.DataModel.Repository;
 
namespace Backend_App.Application.Services;

 
public class CountriesService : ICountriesService
{
    private readonly ICountrySummaryRepository _repo;
    public CountriesService(ICountrySummaryRepository repo) => _repo = repo;
 
    public async Task<List<CountrySummaryDto>> GetSummariesAsync()
    {
        var summaries = await _repo.GetAllAsync();
        return summaries.Select(s => new CountrySummaryDto
        {
            Place = s.Place,
            Country = s.Country,
            TotalQuotas = s.TotalQuotas,
            TotalEvents = s.TotalEvents,
            BestOlympicGames = s.BestOlympicGames,
            SummerOlympicsQuotas = s.SummerOlympicsQuotas,
            WinterOlympicsQuotas = s.WinterOlympicsQuotas,
            TotalGoldMedals = s.TotalGoldMedals,
            TotalSilverMedals = s.TotalSilverMedals,
            TotalBronzeMedals = s.TotalBronzeMedals,
            TotalMedals = s.TotalMedals
        }).ToList();
    }
 
    public async Task<List<CountrySportQuotaDto>?> GetQuotasForCountryAsync(string country)
    {
        var quotas = await _repo.GetQuotasForCountryAsync(country);
        if (quotas.Count == 0) return null;
 
        return quotas.Select(q => new CountrySportQuotaDto { Sport = q.Sport, Quotas = q.Quotas }).ToList();
    }
}