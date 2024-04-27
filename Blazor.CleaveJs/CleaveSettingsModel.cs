using System.Text.Json.Serialization;

namespace Blazor.CleaveJs;

public class CleaveSettingsModel
{
    public string? Value { get; set; }
    public int[]? Blocks { get; set; }
    public string? Delimiter { get; set; }
    public string[]? Delimiters { get; set; }
    public bool? Date { get; set; }
    public string[]? DatePattern { get; set; }
    public bool? Time { get; set; }
    public string[]? TimePattern { get; set; }
    public bool? Numeral { get; set; }
    public NumeralThousandsGroupStyleType? NumeralThousandsGroupStyle { get; set; }
    public bool? Uppercase { get; set; }
    public string? Prefix { get; set; }
    public bool? CreditCard { get; set; }
    public bool? Phone { get; set; }
    public string? PhoneRegionCode { get; set; }
    public string? NumeralDecimalMark { get; set; }
}
