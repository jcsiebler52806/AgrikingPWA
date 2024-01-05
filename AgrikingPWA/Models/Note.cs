using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Note
{
    public int Id { get; set; }

    public string Entity { get; set; } = null!;

    public string EntityKey1 { get; set; } = null!;

    public string? EntityKey2 { get; set; }

    public string? EntityKey3 { get; set; }

    public string? EntityKey4 { get; set; }

    public string? EntityKey5 { get; set; }

    public string NoteText { get; set; } = null!;

    public DateTime NoteDateTime { get; set; }

    public string? UserId { get; set; }

    public virtual User? User { get; set; }
}
