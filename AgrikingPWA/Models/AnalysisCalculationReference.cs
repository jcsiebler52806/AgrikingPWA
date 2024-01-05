using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnalysisCalculationReference
{
    public string? AnalysisCalculationId { get; set; }

    public string? AnalysisTypeId { get; set; }

    public string? SampleTypeId { get; set; }

    public int Id { get; set; }

    public virtual AnalysisType? AnalysisType { get; set; }

    public virtual SampleType? SampleType { get; set; }
}
