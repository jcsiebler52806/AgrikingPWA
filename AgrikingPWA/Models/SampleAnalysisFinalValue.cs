using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleAnalysisFinalValue
{
    public string SampleId { get; set; } = null!;

    public string AnalysisTypeId { get; set; } = null!;

    public string? AnalysisSourceId { get; set; }

    public decimal AnalyzedValue { get; set; }

    public decimal FinalValue { get; set; }

    public string? NonNumericResultValue { get; set; }

    public bool? Hold { get; set; }

    public virtual AnalysisSource? AnalysisSource { get; set; }

    public virtual AnalysisType AnalysisType { get; set; } = null!;

    public virtual Sample Sample { get; set; } = null!;
}
