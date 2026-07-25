using Backend_App.Application.DTO;
 
namespace Backend_App.Application.Services;
 
public interface IResultsService
{
    Task<List<string>> GetSeasonsAsync();
    Task<List<int>> GetYearsAsync(string season);
    Task<List<string>> GetSportsAsync(string season);
    Task<List<OptionDto>> GetEventsAsync(string season, string sport);
 
    Task<List<ResultRowDto>> GetResultsAsync(
        string season, string sport, string eventKey,
        string? athleteSearch, string? countrySearch, string sortBy);
 
    Task<List<MedalTallyDto>> GetMedalTableAsync(string season, int year);
    Task<List<MedalTallyDto>> GetAllTimeMedalTableAsync(string season);
 
    Task<List<CountryMedalDto>> GetCountryMedalistsAsync(string season, int year, string country, string? athleteSearch, string sortBy);
    Task<List<CountryMedalDto>> GetAllTimeCountryMedalistsAsync(string season, string country, string? athleteSearch, string sortBy);
}