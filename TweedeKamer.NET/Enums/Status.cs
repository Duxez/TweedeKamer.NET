using System.Runtime.Serialization;

namespace TweedeKamer.NET.Enums;

public enum ActivityStatus
{
    [EnumMember(Value = "Geannuleerd")]
    Geannuleerd,
    [EnumMember(Value = "Gepland")]
    Gepland,
    [EnumMember(Value = "Uitgevoerd")]
    Uitgevoerd,
    [EnumMember(Value = "Verplaatst")]
    Verplaatst,
    [EnumMember(Value = "Vervallen")]
    Vervallen
}

public enum DecisionStatus
{
    [EnumMember(Value = "Besluit")]
    Besluit,
    [EnumMember(Value = "Concept Voorstel")]
    ConceptVoorstel,
    [EnumMember(Value = "Nog Te Verwerken Besluit")]
    NogTeVerwerkenBesluit,
    [EnumMember(Value = "Voorstel")]
    Voorstel
}