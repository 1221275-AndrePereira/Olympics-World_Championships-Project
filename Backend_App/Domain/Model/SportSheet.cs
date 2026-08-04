namespace Backend_App.Domain.Model;
 
/// 
/// One row per worksheet that was imported (e.g. "Athletics Male Athletes").
/// Groups the individual ClassificationEntry rows under a sport + category.
/// 
public class SportSheet
{
    public int Id { get; set; }
 
    /// Original worksheet name, e.g. "Athletics Male Athletes".
    public string SheetName { get; set; } = string.Empty;
 
    /// Sport name with the category suffix stripped, e.g. "Athletics".
    public string Sport { get; set; } = string.Empty;
 
    /// e.g. "Male Athletes", "Female Athletes", "Teams", "Doubles", "Athletes".
    public string Category { get; set; } = string.Empty;
 
    /// "Summer" or "Winter", based on which Games the sport belongs to.
    public string Season { get; set; } = "Summer";
 
    public List<ClassificationEntry> Entries { get; set; } = new();
    
    /// Four-digit year for the Games this sheet belongs to (e.g. 2024).
    public int Year { get; set; } = 0;
}