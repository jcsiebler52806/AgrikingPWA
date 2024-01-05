using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnalysisProcessType
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<AnalysisSource> AnalysisSources { get; set; } = new List<AnalysisSource>();

    public virtual ICollection<LabPackageAnalysis> LabPackageAnalyses { get; set; } = new List<LabPackageAnalysis>();

    public virtual ICollection<LabSpecialAnalysisRequestAnalysis> LabSpecialAnalysisRequestAnalyses { get; set; } = new List<LabSpecialAnalysisRequestAnalysis>();
}
