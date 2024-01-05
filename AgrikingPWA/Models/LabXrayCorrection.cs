using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class LabXrayCorrection
{
    public int Id { get; set; }

    public string? SampleTypeId { get; set; }

    public string? AnalysisTypeId { get; set; }

    public string? CorrectionAnalysisTypeId { get; set; }

    public decimal CorrectionFactor { get; set; }

    public virtual AnalysisType? AnalysisType { get; set; }

    public virtual AnalysisType? CorrectionAnalysisType { get; set; }

    public virtual SampleType? SampleType { get; set; }
}
