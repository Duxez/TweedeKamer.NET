namespace TweedeKamer.NET.Models;

public class CommitteeSeat : BaseModel
{
    public Guid Id { get; set; }
    public int Gewicht { get; set; }
    public Guid Commissie_Id { get; set; }
}