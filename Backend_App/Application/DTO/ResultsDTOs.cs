namespace Backend_App.Application.DTO;
 
/// One row in an event's result list.
public class ResultRowDto
{
    /// The classification/rank value. -1 means the quota is held but not yet classified.
    public int Rank { get; set; }
    public bool IsPending { get; set; }
    public string Athlete { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
}
 
/// One country's row in a medal table.
public class MedalTallyDto
{
    public string Country { get; set; } = string.Empty;
    public int Gold { get; set; }
    public int Silver { get; set; }
    public int Bronze { get; set; }
    public int Total { get; set; }
}
 
/// One medal won by a country, with full context - used for the drill-down view.
public class CountryMedalDto
{
    public int Year { get; set; }
    public string Sport { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Event { get; set; } = string.Empty;
    public string Athlete { get; set; } = string.Empty;
    public int Rank { get; set; }
    public string Country { get; set; } = string.Empty;
}
 
/// An entry in a dropdown - Key is what you send back to the API, Label is what you show.
public class OptionDto
{
    public string Key { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
}