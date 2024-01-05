using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class RestQueueAction
{
    public int Id { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public DateTime? ResponseDateTime { get; set; }

    public string? Response { get; set; }

    public bool Success { get; set; }

    public int RestQueueEntryId { get; set; }

    public bool Error { get; set; }

    public virtual RestQueueEntry RestQueueEntry { get; set; } = null!;
}
