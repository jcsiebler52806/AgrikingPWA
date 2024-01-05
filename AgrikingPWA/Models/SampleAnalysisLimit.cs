using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleAnalysisLimit
{
    public int Id { get; set; }

    public string? AnalysisSourceId { get; set; }

    public string? SampleTypeId { get; set; }

    public string? AnalysisTypeId { get; set; }

    public decimal? LowLimit { get; set; }

    public decimal? HighLimit { get; set; }

    public virtual AnalysisSource? AnalysisSource { get; set; }

    public virtual AnalysisType? AnalysisType { get; set; }

    public virtual SampleType? SampleType { get; set; }
}
