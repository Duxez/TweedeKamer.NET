namespace TweedeKamer.NET.Models;

public class BaseModel
{
    public Guid Id { get; set; }
    public DateTime ApiGewijzigdOp { get; set; }
    public bool Verwijderd { get; set; }
}