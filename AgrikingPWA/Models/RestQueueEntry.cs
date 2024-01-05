using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class RestQueueEntry
{
    public int Id { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public bool Success { get; set; }

    public bool Error { get; set; }

    public bool Retry { get; set; }

    public int RestQueueId { get; set; }

    public int RestEndpointId { get; set; }

    public string? Method { get; set; }

    public bool Service { get; set; }

    public string? RecordId { get; set; }

    public string? RecordType { get; set; }

    public virtual RestEndpoint RestEndpoint { get; set; } = null!;

    public virtual RestQueue RestQueue { get; set; } = null!;

    public virtual ICollection<RestQueueAction> RestQueueActions { get; set; } = new List<RestQueueAction>();
}
