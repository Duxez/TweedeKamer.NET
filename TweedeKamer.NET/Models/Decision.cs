using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TweedeKamer.NET.Enums;

namespace TweedeKamer.NET.Models;

public class Decision : BaseModel
{
    public Guid Agendapunt_Id { get; set; }
    public VotingType StemmingsSoort { get; set; }
    public string BesluitTekst { get; set; }
    public string Opmerking { get; set; }
    [JsonConverter(typeof(StringEnumConverter))]
    public DecisionStatus Status { get; set; }
    public int AgendapuntZaakBesluitVolgorde { get; set; }
    public DateTime GewijzigdOp { get; set; }
}