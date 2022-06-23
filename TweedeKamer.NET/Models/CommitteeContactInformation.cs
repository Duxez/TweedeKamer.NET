namespace TweedeKamer.NET.Models;

public class CommitteeContactInformation : BaseModel
{
    public string Waarde { get; set; }
    public Guid Commissie_Id { get; set; }
}