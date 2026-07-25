namespace Backend_App.Domain.Model;
 
/// 
/// A single "quota slot" record, normalized out of the original wide-format sheet.
/// Each row in the source sheet had one column per event; this flattens that
/// into one row per (country, event) pair that actually had a value.
/// 
public class ClassificationEntry
{
    public int Id { get; set; }
 
    public int SportSheetId { get; set; }
    public SportSheet? SportSheet { get; set; }
 
    /// Groups columns that came from the same original spreadsheet row
    /// (a country can have several quota slots for the same event).
    public int SourceRowIndex { get; set; }
 
    public string Country { get; set; } = string.Empty;
 
    /// Event/discipline name, with the " Classification" suffix stripped,
    /// e.g. "Freestyle 57kg", "Men's Épée".
    public string Event { get; set; } = string.Empty;
 
    /// Name of the athlete/team/pair if the sheet had one filled in (often blank
    /// in the source file, since athletes aren't nominated yet). Null if not present.
    public string? EntryName { get; set; }
 
    /// 
    /// Raw classification value from the sheet. In the source data, -1 means
    /// "the country holds a quota for this event but no ranking/classification
    /// has been recorded yet". Any other number is an actual classification/ranking.
    /// 
    public int? ClassificationValue { get; set; }
 
    /// True while ClassificationValue == -1 (quota held, not yet classified).
    public bool IsPending => ClassificationValue == -1;
}