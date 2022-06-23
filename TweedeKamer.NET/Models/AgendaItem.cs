namespace TweedeKamer.NET.Models;

public class AgendaItem : BaseModel
{
    public string Nummer { get; set; }
    public string Onderwerp { get; set; }
    public DateTime Eindtijd { get; set; }
    public int Volgorde { get; set; }
    public string Rubriek { get; set; }
    public string Noot { get; set; }
    public string Status { get; set; }
    public Guid Activiteit_Id { get; set; }
}