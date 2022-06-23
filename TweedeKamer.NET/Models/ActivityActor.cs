using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TweedeKamer.NET.Enums;

namespace TweedeKamer.NET.Models;

public class ActivityActor : BaseModel
{
    public Guid ActiviteitId { get; set; }
    public string ActorNaam { get; set; }
    public string ActorFractie { get; set; }
    [JsonConverter(typeof(StringEnumConverter))]
    public Relation Relatie { get; set; }
    public int Volgorde { get; set; }
    public string Functie { get; set; }
    public string Spreektijd { get; set; }
    public string SidActor { get; set; }
    public Guid Persoon_Id { get; set; }
    public Guid Fractie_Id { get; set; }
    public Guid Commissie_Id { get; set; }
}