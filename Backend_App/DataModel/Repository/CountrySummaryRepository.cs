using Microsoft.EntityFrameworkCore;
using Backend_App.Domain.Model;
 
namespace Backend_App.DataModel.Repository;
 
public class CountrySummaryRepository : ICountrySummaryRepository
{
    private readonly AppDbContext _db;
    public CountrySummaryRepository(AppDbContext db) => _db = db;
 
    public async Task<List<CountrySummary>> GetAllAsync() =>
        await _db.CountrySummaries.AsNoTracking().OrderBy(c => c.Place).ToListAsync();
 
    public async Task<List<CountrySportQuota>> GetQuotasForCountryAsync(string country) =>
        await _db.CountrySportQuotas.AsNoTracking()
            .Where(q => q.Country == country)
            .OrderByDescending(q => q.Quotas)
            .ToListAsync();
}