using TweedeKamer.NET.Enums;

namespace TweedeKamer.NET.Models;

public class CommitteeSeatPermanentPerson : BaseModel
{
    public Function Functie { get; set; }
    public DateTime Van { get; set; }
    public Guid CommissieZetel_Id { get; set; }
    public Guid Persoon_Id { get; set; }
}