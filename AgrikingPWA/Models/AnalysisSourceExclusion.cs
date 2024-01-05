using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnalysisSourceExclusion
{
    public int Id { get; set; }

    public string? AnalysisSourceId { get; set; }

    public string? AnalysisTypeId { get; set; }

    public virtual AnalysisSource? AnalysisSource { get; set; }

    public virtual AnalysisType? AnalysisType { get; set; }
}
