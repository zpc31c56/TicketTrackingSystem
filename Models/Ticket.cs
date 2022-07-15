
namespace Models;

public class Ticket
{
    public Guid IssueId { get; set; } 
    public string Issue { get; set; }
    public string Status { get; set; }
    public string Asignee { get; set; }
    public string Reporter { get; set; }
    public string Priority { get; set; }
    public string IssueType { get; set; }
    public DateTime CreateOn { get; set; }
}

