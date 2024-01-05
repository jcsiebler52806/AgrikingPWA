using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleAnalysisWorkingValue
{
    public string SampleId { get; set; } = null!;

    public string AnalysisTypeId { get; set; } = null!;

    public string AnalysisSourceId { get; set; } = null!;

    public decimal AnalyzedValue { get; set; }

    public decimal? CorrectedValue { get; set; }

    public decimal NeighborhoodValue { get; set; }

    public decimal GlobalHvalue { get; set; }

    public string? NonNumericResultValue { get; set; }

    public bool? Hold { get; set; }

    public virtual AnalysisSource AnalysisSource { get; set; } = null!;

    public virtual AnalysisType AnalysisType { get; set; } = null!;

    public virtual Sample Sample { get; set; } = null!;
}
