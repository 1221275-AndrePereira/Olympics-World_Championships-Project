using ClosedXML.Excel;
using Backend_App.Domain.Model;
using Backend_App.DataModel.Repository;
 
namespace Backend_App.Application.Services;
 
/// 
/// Reads the workbook and loads it into the database.
/// Runs once at startup if the database is empty (see Program.cs).
///
/// Sheet handling:
///   - "Sports Quotas"       -> CountrySummary (one row per country)
///   - "Quotas Distribution" -> CountrySportQuota (country x sport quota counts)
///   - "Quotas Totals"       -> skipped (mixed two-tables-in-one-sheet layout,
///                              not needed for the classification/results views)
///   - every other sheet     -> SportSheet + ClassificationEntry (normalized,
///                              one row per country+event that had a value)
/// 
public class ExcelImportService
{
    private static readonly string[] SkippedSummarySheets = { "Sports Quotas", "Quotas Distribution", "Quotas Totals" };
 
    // Sports that appear at the Winter Games; everything else is treated as Summer.
    private static readonly HashSet<string> WinterSports = new(StringComparer.OrdinalIgnoreCase)
    {
        "Alpine Skiing", "Biathlon", "Bobsleigh", "CrossCountry Skiing", "Cross-Country Skiing",
        "Curling", "Figure Skating", "Freestyle Skiing", "Ice Hockey", "Luge", "Nordic Combined",
        "Short Speed Skating", "Short Track Speed Skating", "Skeleton", "Ski Jumping",
        "Snowboarding", "Speed Skating"
    };
 
    private readonly ILogger<ExcelImportService> _logger;
 
    public ExcelImportService(ILogger<ExcelImportService> logger)
    {
        _logger = logger;
    }
 
    public void Import(string excelFilePath, AppDbContext db)
    {
        if (!File.Exists(excelFilePath))
        {
            _logger.LogWarning("Excel file not found at {Path}; skipping import.", excelFilePath);
            return;
        }
 
        using var workbook = new XLWorkbook(excelFilePath);
 
        foreach (var ws in workbook.Worksheets)
        {
            if (SkippedSummarySheets.Contains(ws.Name))
                continue;
 
            ImportSportSheet(ws, db);
        }
 
        ImportSportsQuotas(workbook, db);
        ImportQuotasDistribution(workbook, db);
 
        db.SaveChanges();
        _logger.LogInformation("Excel import complete.");
    }
 
    private void ImportSportSheet(IXLWorksheet ws, AppDbContext db)
    {
        var usedRange = ws.RangeUsed();
        if (usedRange is null || usedRange.RowCount() < 2) return;
 
        var headerRow = usedRange.Row(1);
        var lastCol = usedRange.ColumnCount();
 
        int countryCol = -1;
        var eventColumns = new List<(int Col, string EventName)>();
        int nameCol = 1; // first column typically holds Athlete/Team/Pair name (often blank)
 
        for (int c = 1; c <= lastCol; c++)
        {
            var header = headerRow.Cell(c).GetString().Trim();
            if (header.Equals("Country", StringComparison.OrdinalIgnoreCase))
            {
                countryCol = c;
            }
            else if (header.EndsWith("Classification", StringComparison.OrdinalIgnoreCase))
            {
                var eventName = header[..^"Classification".Length].Trim();
                eventColumns.Add((c, eventName));
            }
        }
 
        if (countryCol == -1 || eventColumns.Count == 0)
        {
            _logger.LogWarning("Sheet '{Sheet}' has no Country column or Classification columns; skipping.", ws.Name);
            return;
        }
 
        var (sport, category) = SplitSheetName(ws.Name);
        var season = WinterSports.Contains(sport) ? "Winter" : "Summer";
 
        var sportSheet = new SportSheet
        {
            SheetName = ws.Name,
            Sport = sport,
            Category = category,
            Season = season
        };
        db.SportSheets.Add(sportSheet);
 
        for (int r = 2; r <= usedRange.RowCount(); r++)
        {
            var row = usedRange.Row(r);
            var country = row.Cell(countryCol).GetString().Trim();
            if (string.IsNullOrWhiteSpace(country)) continue;
 
            var name = row.Cell(nameCol).GetString().Trim();
            string? entryName = string.IsNullOrWhiteSpace(name) ? null : name;
 
            foreach (var (col, eventName) in eventColumns)
            {
                var cell = row.Cell(col);
                if (cell.IsEmpty()) continue;
 
                int? value = cell.TryGetValue<int>(out var intVal) ? intVal : null;
 
                sportSheet.Entries.Add(new ClassificationEntry
                {
                    SourceRowIndex = r,
                    Country = country,
                    Event = eventName,
                    EntryName = entryName,
                    ClassificationValue = value
                });
            }
        }
    }
 
    private void ImportSportsQuotas(XLWorkbook workbook, AppDbContext db)
    {
        if (!workbook.TryGetWorksheet("Sports Quotas", out var ws)) return;
 
        var usedRange = ws.RangeUsed();
        if (usedRange is null) return;
 
        var headerRow = usedRange.Row(1);
        var columnIndex = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        for (int c = 1; c <= usedRange.ColumnCount(); c++)
        {
            var header = headerRow.Cell(c).GetString().Trim();
            if (!string.IsNullOrWhiteSpace(header) && !columnIndex.ContainsKey(header))
                columnIndex[header] = c;
 
            // We only need up to "Medals/Quotas Ratio"; the rest is a per-event matrix
            // already covered by the per-sport sheets.
            if (header == "Medals/Quotas Ratio") break;
        }
 
        int Col(string name) => columnIndex.TryGetValue(name, out var i) ? i : -1;
        int GetInt(IXLRangeRow row, int col) => col > 0 && row.Cell(col).TryGetValue<int>(out var v) ? v : 0;
 
        for (int r = 2; r <= usedRange.RowCount(); r++)
        {
            var row = usedRange.Row(r);
            var country = row.Cell(Col("Country")).GetString().Trim();
            if (string.IsNullOrWhiteSpace(country)) continue;
 
            db.CountrySummaries.Add(new CountrySummary
            {
                Place = GetInt(row, Col("Place")),
                Country = country,
                TotalQuotas = GetInt(row, Col("Total Quotas")),
                TotalEvents = GetInt(row, Col("Total Events")),
                BestOlympicGames = row.Cell(Col("Best Olympic Games")).GetString().Trim(),
                SummerOlympicsQuotas = GetInt(row, Col("Summer Olympics Quotas")),
                WinterOlympicsQuotas = GetInt(row, Col("Winter Olympics Quotas")),
                TotalGoldMedals = GetInt(row, Col("Total Gold Medals")),
                TotalSilverMedals = GetInt(row, Col("Total Silver Medals")),
                TotalBronzeMedals = GetInt(row, Col("Total Bronze Medals")),
                TotalMedals = GetInt(row, Col("Total Medals")),
                SummerGoldMedals = GetInt(row, Col("Summer Gold Medals")),
                SummerSilverMedals = GetInt(row, Col("Summer Silver Medals")),
                SummerBronzeMedals = GetInt(row, Col("Summer Bronze Medals")),
                SummerTotalMedals = GetInt(row, Col("Summer Total Medals")),
                WinterGoldMedals = GetInt(row, Col("Winter Gold Medals")),
                WinterSilverMedals = GetInt(row, Col("Winter Silver Medals")),
                WinterBronzeMedals = GetInt(row, Col("Winter Bronze Medals")),
                WinterTotalMedals = GetInt(row, Col("Winter Total Medals"))
            });
        }
    }
 
    private void ImportQuotasDistribution(XLWorkbook workbook, AppDbContext db)
    {
        if (!workbook.TryGetWorksheet("Quotas Distribution", out var ws)) return;
 
        var usedRange = ws.RangeUsed();
        if (usedRange is null) return;
 
        var headerRow = usedRange.Row(1);
        int countryCol = -1;
        var sportColumns = new List<(int Col, string Sport)>();
 
        for (int c = 1; c <= usedRange.ColumnCount(); c++)
        {
            var header = headerRow.Cell(c).GetString().Trim();
            if (header.Equals("Country", StringComparison.OrdinalIgnoreCase))
            {
                countryCol = c;
            }
            else if (header.EndsWith("Quotas", StringComparison.OrdinalIgnoreCase) &&
                     !header.Equals("Total Quotas", StringComparison.OrdinalIgnoreCase))
            {
                sportColumns.Add((c, header[..^"Quotas".Length].Trim()));
            }
        }
 
        if (countryCol == -1) return;
 
        for (int r = 2; r <= usedRange.RowCount(); r++)
        {
            var row = usedRange.Row(r);
            var country = row.Cell(countryCol).GetString().Trim();
            if (string.IsNullOrWhiteSpace(country)) continue;
 
            foreach (var (col, sport) in sportColumns)
            {
                var cell = row.Cell(col);
                if (cell.TryGetValue<int>(out var qty) && qty > 0)
                {
                    db.CountrySportQuotas.Add(new CountrySportQuota
                    {
                        Country = country,
                        Sport = sport,
                        Quotas = qty
                    });
                }
            }
        }
    }
 
    /// <summary>
    /// Splits a sheet name like "Athletics Male Athletes" into ("Athletics", "Male Athletes").
    /// Excel sheet names are capped at 31 characters, so several names in this workbook have
    /// their "Athletes" suffix truncated (e.g. "CrossCountry Skiing Female Athl"). Rather than
    /// matching the full suffix, we split on where the "Male"/"Female" token starts and
    /// normalize whatever trailing fragment remains.
    /// </summary>
    private static (string Sport, string Category) SplitSheetName(string sheetName)
    {
        if (sheetName.EndsWith("Teams", StringComparison.OrdinalIgnoreCase))
            return (sheetName[..^"Teams".Length].Trim(' ', '-'), "Teams");
 
        if (sheetName.EndsWith("Doubles", StringComparison.OrdinalIgnoreCase))
            return (sheetName[..^"Doubles".Length].Trim(' ', '-'), "Doubles");
 
        var femaleIdx = sheetName.LastIndexOf("Female", StringComparison.OrdinalIgnoreCase);
        if (femaleIdx >= 0)
            return (sheetName[..femaleIdx].Trim(' ', '-'), "Female Athletes");
 
        var maleIdx = sheetName.LastIndexOf("Male", StringComparison.OrdinalIgnoreCase);
        if (maleIdx >= 0)
            return (sheetName[..maleIdx].Trim(' ', '-'), "Male Athletes");
 
        // Handles sheets like "Equestrian Athletes" / "Rhytmic Gymnastics Athletes"
        // where there's no Male/Female split.
        var athletesIdx = sheetName.IndexOf("Athlet", StringComparison.OrdinalIgnoreCase);
        if (athletesIdx >= 0)
            return (sheetName[..athletesIdx].Trim(' ', '-'), "Athletes");
 
        return (sheetName, "General");
    }
}