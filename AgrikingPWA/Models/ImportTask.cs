using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ImportTask
{
    public int Id { get; set; }

    public string Process { get; set; } = null!;

    public string? Step { get; set; }

    public int PercentComplete { get; set; }

    public DateTime? Started { get; set; }

    public DateTime? Ended { get; set; }

    public virtual ICollection<ImportTaskLog> ImportTaskLogs { get; set; } = new List<ImportTaskLog>();
}
