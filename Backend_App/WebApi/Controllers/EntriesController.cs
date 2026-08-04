using Microsoft.AspNetCore.Mvc;
using Backend_App.Application.DTO;
using Backend_App.Application.Services;
 
namespace Backend_App.WebApi.Controllers;
 
[ApiController]
[Route("api/[controller]")]
public class EntriesController : ControllerBase
{
    private readonly IEntriesService _entries;
    public EntriesController(IEntriesService entries) => _entries = entries;
 
    /// <summary>Paged, filterable list of classification entries (the quota board).</summary>
    [HttpGet]
    public async Task<IActionResult> GetEntries(
        [FromQuery] string? sport, [FromQuery] string? category, [FromQuery] string? country,
        [FromQuery] string? search, [FromQuery] bool? pendingOnly,
        [FromQuery] int page = 1, [FromQuery] int pageSize = 50, [FromQuery] string? sortBy = null)
    {
        var filter = new EntriesFilterDto
        {
            Sport = sport, Category = category, Country = country,
            Search = search, PendingOnly = pendingOnly, Page = page, PageSize = pageSize
        };
        filter.SortBy = sortBy;
        return Ok(await _entries.GetEntriesAsync(filter));
    }
 
    [HttpGet("countries")]
    public async Task<IActionResult> GetCountries() => Ok(await _entries.GetCountriesAsync());
}