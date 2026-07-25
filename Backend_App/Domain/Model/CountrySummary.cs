namespace Backend_App.Domain.Model;
 
/// 
/// One row per country, imported from the "Sports Quotas" summary sheet.
/// 
public class CountrySummary
{
    public int Id { get; set; }
 
    public int Place { get; set; }
    public string Country { get; set; } = string.Empty;
    public int TotalQuotas { get; set; }
    public int TotalEvents { get; set; }
    public string? BestOlympicGames { get; set; }
    public int SummerOlympicsQuotas { get; set; }
    public int WinterOlympicsQuotas { get; set; }
    public int TotalGoldMedals { get; set; }
    public int TotalSilverMedals { get; set; }
    public int TotalBronzeMedals { get; set; }
    public int TotalMedals { get; set; }
 
    // All-time (historical, across every past Games), split by season -
    // this is what powers the "All-Time Medal Table" feature.
    public int SummerGoldMedals { get; set; }
    public int SummerSilverMedals { get; set; }
    public int SummerBronzeMedals { get; set; }
    public int SummerTotalMedals { get; set; }
    public int WinterGoldMedals { get; set; }
    public int WinterSilverMedals { get; set; }
    public int WinterBronzeMedals { get; set; }
    public int WinterTotalMedals { get; set; }
}