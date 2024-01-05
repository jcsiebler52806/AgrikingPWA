using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class RestEndpoint
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Script { get; set; }

    public string? Deploy { get; set; }

    public int DefaultQueueId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<RestQueueEntry> RestQueueEntries { get; set; } = new List<RestQueueEntry>();
}
