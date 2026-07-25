using Microsoft.AspNetCore.Mvc;
using Backend_App.Application.Services;
 
namespace Backend_App.WebApi.Controllers;
 
[ApiController]
[Route("api/[controller]")]
public class ResultsController : ControllerBase
{
    private readonly IResultsService _results;
    public ResultsController(IResultsService results) => _results = results;
 
    /// <summary>Results for a single event (eventKey comes from GET /api/browse/events).</summary>
    [HttpGet]
    public async Task<IActionResult> GetResults(
        [FromQuery] string season, [FromQuery] string sport, [FromQuery] string eventKey,
        [FromQuery] string? athlete, [FromQuery] string? country, [FromQuery] string sortBy = "rank")
    {
        var results = await _results.GetResultsAsync(season, sport, eventKey, athlete, country, sortBy);
        return Ok(results);
    }
 
    [HttpGet("medal-table")]
    public async Task<IActionResult> GetMedalTable([FromQuery] string season, [FromQuery] int year) =>
        Ok(await _results.GetMedalTableAsync(season, year));
 
    [HttpGet("medal-table/all-time")]
    public async Task<IActionResult> GetAllTimeMedalTable([FromQuery] string season) =>
        Ok(await _results.GetAllTimeMedalTableAsync(season));
 
    [HttpGet("medalists")]
    public async Task<IActionResult> GetCountryMedalists(
        [FromQuery] string season, [FromQuery] int year, [FromQuery] string country,
        [FromQuery] string? athlete, [FromQuery] string sortBy = "rank") =>
        Ok(await _results.GetCountryMedalistsAsync(season, year, country, athlete, sortBy));
 
    [HttpGet("medalists/all-time")]
    public async Task<IActionResult> GetAllTimeCountryMedalists(
        [FromQuery] string season, [FromQuery] string country,
        [FromQuery] string? athlete, [FromQuery] string sortBy = "rank") =>
        Ok(await _results.GetAllTimeCountryMedalistsAsync(season, country, athlete, sortBy));
}