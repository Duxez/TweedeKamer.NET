using System.Runtime.Serialization;

namespace TweedeKamer.NET.Enums;

public enum ActivityTypes
{
    [EnumMember(Value = "Aanbieding")]
    Aanbieding,
    [EnumMember(Value = "Ad-hocbesluitvorming")]
    AdHocBesluitsvorming,
    [EnumMember(Value = "Afscheid")]
    Afscheid,
    [EnumMember(Value = "Algemeen overleg")]
    Algemeenoverleg,
    [EnumMember(Value = "Begrotingsoverleg")]
    Begrotingsoverleg,
    [EnumMember(Value = "Beëdiging")]
    Beediging,
    [EnumMember(Value = "Bijzondere procedure")]
    BijzonderProcedure,
    [EnumMember(Value = "Commissiedebat")]
    Commissiedebat,
    [EnumMember(Value = "Constituerende vergadering")]
    Constituerendevergadering,
    [EnumMember(Value = "Delegatievergadering")]
    Delegatievergadering,
    [EnumMember(Value = "E-mailprocedure")]
    Emailprocedure,
    [EnumMember(Value = "Gesprek")]
    Gesprek,
    [EnumMember(Value = "Hamerstukken")]
    Hamerstukken,
    [EnumMember(Value = "Herdenking")]
    Herdenking,
    [EnumMember(Value = "Hoorzitting")]
    Hoorzitting,
    [EnumMember(Value = "Inbreng feitelijke vragen")]
    InbrengFeitelijkeVragen,
    [EnumMember(Value = "Inbreng politieke dialoog met de Europese Commissie")]
    InbrengPolitiekeDialoogMetDeEuropeseCommissie,
    [EnumMember(Value = "Inbreng schriftelijk overleg")]
    InbrengSchriftelijkOverleg,
    [EnumMember(Value = "Inbreng verslag (wetsvoorstel)")]
    InbrengVerslagWetsvoorstel,
    [EnumMember(Value = "Notaoverleg")]
    Notaoverleg,
    [EnumMember(Value = "Ontbijtbijeenkomst Parlement en Wetenschap")]
    OntbijtbijeenkomstParlementEnWetenschap,
    [EnumMember(Value = "Petitie")]
    Petitie,
    [EnumMember(Value = "Plenair debat (debat)")]
    PlenairDebatDebat,
    [EnumMember(Value = "Plenair debat (dertigledendebat)")]
    PlenairDebatDertigledendebat,
    [EnumMember(Value = "Plenair debat (initiatiefwetgeving)")]
    PlenairDebatInitiatiefwetgeving,
    [EnumMember(Value = "Plenair debat (interpellatiedebat)")]
    PlenairDebatInterpellatiedebat,
    [EnumMember(Value = "Plenair debat (overig)")]
    PlenairDebatOverig,
    [EnumMember(Value = "Plenair debat (tweeminutendebat)")]
    PlenairDebatTweeminutendebat,
    [EnumMember(Value = "Plenair debat (wetgeving)")]
    PlenairDebatWetgeving,
    [EnumMember(Value = "Procedurevergadering")]
    Procedurevergadering,
    [EnumMember(Value = "Regeling van werkzaamheden")]
    RegelingVanWerkzaamheden,
    [EnumMember(Value = "AlgemRondetafelgesprekeen")]
    Rondetafelgesprek,
    [EnumMember(Value = "Schriftelijk commentaar algemeen")]
    SchriftelijkCommentaarAlgemeen,
    [EnumMember(Value = "Schriftelijk commentaar gericht")]
    SchriftelijkCommentaarGericht,
    [EnumMember(Value = "Stemmingen")]
    Stemmingen,
    [EnumMember(Value = "echnische briefing")]
    TechnischeBriefing,
    [EnumMember(Value = "Toespraak")]
    Toespraak,
    [EnumMember(Value = "Vergadering")]
    Vergadering,
    [EnumMember(Value = "Verhoor")]
    Verhoor,
    [EnumMember(Value = "Verklaring")]
    Verklaring,
    [EnumMember(Value = "Vragenuur")]
    Vragenuur,
    [EnumMember(Value = "Werkbezoek")]
    Werkbezoek,
    [EnumMember(Value = "Wetgevingsoverleg")]
    Wetgevingsoverleg,
    [EnumMember(Value = "Zaalpreparatie")]
    Zaalpreparatie
}