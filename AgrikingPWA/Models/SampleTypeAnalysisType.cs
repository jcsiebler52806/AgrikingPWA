using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleTypeAnalysisType
{
    public string SampleTypeId { get; set; } = null!;

    public string AnalysisTypeId { get; set; } = null!;

    public bool RequiredRations { get; set; }

    public bool RequiredFinal { get; set; }

    public decimal? HighLimitValue { get; set; }

    public decimal? LowLimitValue { get; set; }

    public decimal? StandardValue { get; set; }

    public decimal? HighLimitValueQc { get; set; }

    public decimal? LowLimitValueQc { get; set; }

    public decimal? DefaultLowValue { get; set; }

    public decimal? DefaultHighValue { get; set; }

    public virtual AnalysisType AnalysisType { get; set; } = null!;

    public virtual SampleType SampleType { get; set; } = null!;
}
