using TweedeKamer.NET.Enums;

namespace TweedeKamer.NET.Models;

public class Committee : BaseModel
{
    public int Nummer { get; set; }
    public CommitteeType Soort { get; set; }
    public string Afkorting { get; set; }
    public string NaamNL { get; set; }
    public string NaamEN { get; set; }
    public string NaamWebNL { get; set; }
    public string NaamWebEN { get; set; }
    public DateTime DatumActief { get; set; }
    public DateTime DatumInactief { get; set; }
}