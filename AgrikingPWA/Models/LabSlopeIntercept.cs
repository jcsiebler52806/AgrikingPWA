using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class LabSlopeIntercept
{
    public int Id { get; set; }

    public string? SampleTypeId { get; set; }

    public string? AnalysisTypeId { get; set; }

    public decimal Intercept { get; set; }

    public decimal Slope { get; set; }

    public virtual AnalysisType? AnalysisType { get; set; }

    public virtual SampleType? SampleType { get; set; }
}
