using System.Runtime.Serialization;

namespace TweedeKamer.NET.Enums;

public enum CommitteeType
{
    [EnumMember(Value = "Algemeen")]
    Algemeen,
    [EnumMember(Value = "Contactgroepen")]
    Contactgroepen,
    [EnumMember(Value = "Dienst Commissieondersteuning Bestuur en Onderwijs")]
    DienstCommissieondersteuningBestuurEnOnderwijs,
    [EnumMember(Value = "Dienst Commissieondersteuning Internationaal en Ruimtelijk")]
    DiensCommissieondersteuningInternationaalEnRuimtelijk,
    [EnumMember(Value = "Dienst Commissieondersteuning Sociaal en Financieel")]
    DiensCommissieondersteuningSociaalEnFinancieel,
    [EnumMember(Value = "Interparlementaire betrekkingen")]
    InterparlementaireBetrekkingen,
    [EnumMember(Value = "Overige Commissies")]
    OverigeCommissies
}