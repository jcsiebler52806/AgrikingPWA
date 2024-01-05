using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleAnalysisReportRange
{
    public int Id { get; set; }

    public string? CountryId { get; set; }

    public string? SampleTypeId { get; set; }

    public string? AnalysisTypeId { get; set; }

    public decimal? LowValue { get; set; }

    public decimal? HighValue { get; set; }

    public string? Description { get; set; }

    public string? Narrative { get; set; }

    public int RiskFactor { get; set; }

    public virtual AnalysisType? AnalysisType { get; set; }

    public virtual Country? Country { get; set; }

    public virtual SampleType? SampleType { get; set; }
}
