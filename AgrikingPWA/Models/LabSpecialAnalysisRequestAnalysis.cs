using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class LabSpecialAnalysisRequestAnalysis
{
    public string LabSpecialAnalysisRequestId { get; set; } = null!;

    public string AnalysisTypeId { get; set; } = null!;

    public string? ProcessTypeId { get; set; }

    public virtual AnalysisType AnalysisType { get; set; } = null!;

    public virtual LabSpecialAnalysisRequest LabSpecialAnalysisRequest { get; set; } = null!;

    public virtual AnalysisProcessType? ProcessType { get; set; }
}
