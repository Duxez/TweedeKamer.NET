using System.Runtime.Serialization;

namespace TweedeKamer.NET.Enums;

public enum Function
{
    [EnumMember(Value = "Eerste ondervoorzitter Tweede Kamer")]
    EersteOndervoorzitterTweedeKamer,
    [EnumMember(Value = "Fng ondervoorzitter")]
    FngOndervoorzitter,
    [EnumMember(Value = "Fng voorzitter")]
    FngVoorzitter,
    [EnumMember(Value = "Lid")]
    Lid,
    [EnumMember(Value = "Ondervoorzitter")]
    Ondervoorzitter,
    [EnumMember(Value = "Plv. lid")]
    PlvLid,
    [EnumMember(Value = "Tweede ondervoorzitter Tweede Kamer")]
    TweedeOndervoorzitterTweedeKamer,
    [EnumMember(Value = "Voorzitter")]
    Voorzitter
}