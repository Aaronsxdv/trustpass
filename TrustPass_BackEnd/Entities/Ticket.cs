using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

[Table("tickets")]
public class Ticket
{
    public int UserId { get; set; }
    public int MatchId { get; set; }
    public string? Entrance { get; set; }
    public string? Seat { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    // public User User { get; set; } = null!;
    // public Match Match { get; set; } = null!;
}