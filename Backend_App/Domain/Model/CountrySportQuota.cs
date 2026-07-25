namespace Backend_App.Domain.Model;
 
/// 
/// How many quota spots a country holds in a given sport, imported from
/// the "Quotas Distribution" summary sheet (one row per country there,
/// one column per sport - flattened here into one row per country+sport).
/// 
public class CountrySportQuota
{
    public int Id { get; set; }
 
    public string Country { get; set; } = string.Empty;
    public string Sport { get; set; } = string.Empty;
    public int Quotas { get; set; }
}