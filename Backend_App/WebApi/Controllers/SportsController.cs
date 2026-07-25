using Microsoft.AspNetCore.Mvc;
using Backend_App.Application.Services;
 
namespace Backend_App.WebApi.Controllers;
 
[ApiController]
[Route("api/[controller]")]
public class SportsController : ControllerBase
{
    private readonly IEntriesService _entries;
    public SportsController(IEntriesService entries) => _entries = entries;
 
    /// <summary>Distinct list of sports, with their categories and which Games they belong to.</summary>
    [HttpGet]
    public async Task<IActionResult> GetSports() => Ok(await _entries.GetSportsAsync());
}