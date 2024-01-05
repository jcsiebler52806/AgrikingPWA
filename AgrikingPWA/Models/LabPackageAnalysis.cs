using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class LabPackageAnalysis
{
    public string LabPackageId { get; set; } = null!;

    public string AnalysisTypeId { get; set; } = null!;

    public string? ProcessTypeId { get; set; }

    public int? ReportSequence { get; set; }

    public virtual AnalysisType AnalysisType { get; set; } = null!;

    public virtual LabPackage LabPackage { get; set; } = null!;

    public virtual AnalysisProcessType? ProcessType { get; set; }
}
