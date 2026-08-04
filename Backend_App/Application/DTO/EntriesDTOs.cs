namespace Backend_App.Application.DTO;
 
public class ClassificationEntryDto
{
    public int Id { get; set; }
    public string Sport { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Season { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Event { get; set; } = string.Empty;
    public string? EntryName { get; set; }
    public int? ClassificationValue { get; set; }
    public bool IsPending { get; set; }
}
 
public class PagedResultDto<T>
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int TotalItems { get; set; }
    public int TotalPages { get; set; }
    public List<T> Items { get; set; } = new();
}
 
public class SportSummaryDto
{
    public string Sport { get; set; } = string.Empty;
    public string Season { get; set; } = string.Empty;
    public List<string> Categories { get; set; } = new();
}
 
public class EntriesFilterDto
{
    public string? Sport { get; set; }
    public string? Category { get; set; }
    public string? Country { get; set; }
    public string? Search { get; set; }
    public bool? PendingOnly { get; set; }
    public string? SortBy { get; set; }
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 50;
}
 
public class CountrySummaryDto
{
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
}
 
public class CountrySportQuotaDto
{
    public string Sport { get; set; } = string.Empty;
    public int Quotas { get; set; }
}