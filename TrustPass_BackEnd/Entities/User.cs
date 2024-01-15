﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

[Table("users")]
public class User
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? ExternalId { get; set; }
    public string? IdentityHash { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public List<Match> Matches { get; } = new();
    public List<Ticket> Tickets { get; } = new();
}