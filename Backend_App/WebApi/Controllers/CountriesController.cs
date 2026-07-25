using Microsoft.AspNetCore.Mvc;
using Backend_App.Application.Services;
 
namespace Backend_App.WebApi.Controllers;
 
[ApiController]
[Route("api/[controller]")]
public class CountriesController : ControllerBase
{
    private readonly ICountriesService _countries;
    public CountriesController(ICountriesService countries) => _countries = countries;
 
    /// <summary>Country quota/medal leaderboard from the "Sports Quotas" summary sheet.</summary>
    [HttpGet("summary")]
    public async Task<IActionResult> GetSummaries() => Ok(await _countries.GetSummariesAsync());
 
    /// <summary>Per-sport quota breakdown for a single country.</summary>
    [HttpGet("{country}/quotas")]
    public async Task<IActionResult> GetCountryQuotas(string country)
    {
        var quotas = await _countries.GetQuotasForCountryAsync(country);
        if (quotas is null) return NotFound();
        return Ok(quotas);
    }
}