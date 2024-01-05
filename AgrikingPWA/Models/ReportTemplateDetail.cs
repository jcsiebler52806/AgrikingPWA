using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ReportTemplateDetail
{
    public int Id { get; set; }

    public int ReportTemplateId { get; set; }

    public string? LabPackageId { get; set; }

    public bool Active { get; set; }

    public virtual LabPackage? LabPackage { get; set; }

    public virtual ReportTemplate ReportTemplate { get; set; } = null!;
}
