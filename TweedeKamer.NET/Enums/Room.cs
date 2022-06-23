using System.Runtime.Serialization;

namespace TweedeKamer.NET.Enums;

public enum Room
{
    [EnumMember(Value = "Eerste Kamer en Tweede Kamer")]
    EersteKamerEnTweedeKamer,
    [EnumMember(Value = "Eerste Kamer")]
    EersteKamer,
    [EnumMember(Value = "Tweede Kamer")]
    TweedeKamer
}