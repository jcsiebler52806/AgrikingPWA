using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class RestQueue
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Account { get; set; }

    public string? ConsumerKey { get; set; }

    public string? ConsumerSecret { get; set; }

    public string? UserToken { get; set; }

    public string? UserSecret { get; set; }

    public string? BaseUrl { get; set; }

    public string? Environment { get; set; }

    public virtual ICollection<RestQueueEntry> RestQueueEntries { get; set; } = new List<RestQueueEntry>();
}
