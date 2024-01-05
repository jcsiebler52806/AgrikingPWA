using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class LabPackage
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Cost { get; set; }

    public decimal Price { get; set; }

    public bool Active { get; set; }

    public bool? ReportOnly { get; set; }

    public virtual ICollection<LabPackageAnalysis> LabPackageAnalyses { get; set; } = new List<LabPackageAnalysis>();

    public virtual ICollection<ReportTemplateDetail> ReportTemplateDetails { get; set; } = new List<ReportTemplateDetail>();

    public virtual ICollection<Sample> Samples { get; set; } = new List<Sample>();
}
