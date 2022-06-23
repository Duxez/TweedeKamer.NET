using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TweedeKamer.NET.Enums;
using DateType = TweedeKamer.NET.Enums.DateType;

namespace TweedeKamer.NET.Models;

public class Activity : BaseModel
{
    [JsonConverter(typeof(StringEnumConverter))]
    [Description("Type of Activity")]
    public ActivityTypes Soort { get; set; }
    [Description("Internal identification number")]
    public string Nummer { get; set; }
    [Description("Subject")]
    public string Onderwerp { get; set; }
    [Description("Date context for an activity")]
    public DateType DatumSoort { get; set; }
    [Description("Date of an activity")]
    public DateTime Datum { get; set; }
    public DateTime Aanvangstijd { get; set; }
    public DateTime Eindtijd { get; set; }
    public string Locatie { get; set; }
    public bool Besloten { get; set; }
    public ActivityStatus ActivityStatus { get; set; }
    public string Vergaderjaar { get; set; }
    public Room Kamer { get; set; }
    public string Noot { get; set; }
    public string VRSNummer { get; set; }
    public string SidVoortouw { get; set; }
    public string Voortouwnaam { get; set; }
    public string Voortouwafkorting { get; set; }
    public string Voortouwkortenaam { get; set; }
    public Guid Voortouwcommissie_Id { get; set; }
    public DateTime Aanvraagdatum { get; set; }
    public DateTime VerzoekEersteVerlenging { get; set; }
    public DateTime DatumMededelingEersteVerlenging { get; set; }
    public DateTime DatumVerzoekTweedeVerlenging { get; set; }
    public DateTime DatumMededelingTweedeVerlenging { get; set; }
    public DateTime Vervaldatum { get; set; }
}