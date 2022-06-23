using System.Runtime.Serialization;

namespace TweedeKamer.NET.Enums;

public enum Relation
{
    [EnumMember(Value = "Aanvrager")]
    Aanvrager,
    [EnumMember(Value = "Afgemeld")]
    Afgemeld,
    [EnumMember(Value = "Bewindspersoon c.a.")]
    BewindspersoonCA,
    [EnumMember(Value = "Deelnemende fractie")]
    DeelnemendeFractie,
    [EnumMember(Value = "Deelnemer")]
    Deelnemer,
    [EnumMember(Value = "Initiatiefnemer")]
    Initiatiefnemer,
    [EnumMember(Value = "Interpellant")]
    Interpellant,
    [EnumMember(Value = "Volgcommissie")]
    Volgcommissie
}