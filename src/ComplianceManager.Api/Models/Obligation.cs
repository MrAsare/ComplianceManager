namespace ComplianceManager.Api.Models;
public class Obligation
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public DateTime DueOn { get; set; }
    public bool IsComplete {get; set;}
}