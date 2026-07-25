using Microsoft.AspNetCore.Mvc;
using Backend_App.Application.Services;
 
namespace Backend_App.WebApi.Controllers;
 
/// Powers the cascading Season -> Year -> Sport -> Event dropdowns in the Results Browser.</summary>
[ApiController]
[Route("api/[controller]")]
public class BrowseController : ControllerBase
{
    private readonly IResultsService _results;
    public BrowseController(IResultsService results) => _results = results;
 
    [HttpGet("seasons")]
    public async Task<IActionResult> GetSeasons() => Ok(await _results.GetSeasonsAsync());
 
    [HttpGet("years")]
    public async Task<IActionResult> GetYears([FromQuery] string season) => Ok(await _results.GetYearsAsync(season));
 
    [HttpGet("sports")]
    public async Task<IActionResult> GetSports([FromQuery] string season) => Ok(await _results.GetSportsAsync(season));
 
    [HttpGet("events")]
    public async Task<IActionResult> GetEvents([FromQuery] string season, [FromQuery] string sport) =>
        Ok(await _results.GetEventsAsync(season, sport));
}