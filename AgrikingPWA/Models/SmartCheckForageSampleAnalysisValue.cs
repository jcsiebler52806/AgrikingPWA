using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SmartCheckForageSampleAnalysisValue
{
    public int Id { get; set; }

    public int SmartCheckForageSampleId { get; set; }

    public string? SampleId { get; set; }

    public string? AnalysisTypeId { get; set; }

    public string? AnalysisSourceId { get; set; }

    public decimal AnalyzedValue { get; set; }

    public decimal FinalValue { get; set; }

    public string? NonNumericResultValue { get; set; }

    public virtual AnalysisSource? AnalysisSource { get; set; }

    public virtual AnalysisType? AnalysisType { get; set; }

    public virtual Sample? Sample { get; set; }

    public virtual SmartCheckForageSample SmartCheckForageSample { get; set; } = null!;
}
