using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace TweedeKamer.NET.Enums;

public enum DateType
{
    [EnumMember(Value = "Dag")]
    Dag,
    [EnumMember(Value = "Meerdaags")]
    Meerdaags,
    [EnumMember(Value = "Nog geen datum bekend")]
    NogGeenDatumBekend,
    [EnumMember(Value = "Weeknummer")]
    Weeknummer
}