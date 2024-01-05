using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Report
{
    public int Id { get; set; }

    public string? ReportName { get; set; }

    public string? Sender { get; set; }

    public string? Subject { get; set; }

    public string? Content { get; set; }

    public bool ClientReport { get; set; }

    public string? DefaultFilename { get; set; }

    public int? ReportGroupId { get; set; }

    public virtual ICollection<DistributionTemp> DistributionTemps { get; set; } = new List<DistributionTemp>();

    public virtual ICollection<Distribution> Distributions { get; set; } = new List<Distribution>();
}
