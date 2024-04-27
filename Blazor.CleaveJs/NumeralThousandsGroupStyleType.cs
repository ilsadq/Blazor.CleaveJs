using System.Runtime.Serialization;

namespace Blazor.CleaveJs;

public enum NumeralThousandsGroupStyleType
{
    [EnumMember(Value = "thousand")]
    Thousand,
    [EnumMember(Value = "lakh")]
    Lakh,
    [EnumMember(Value = "wan")]
    Wan
}
