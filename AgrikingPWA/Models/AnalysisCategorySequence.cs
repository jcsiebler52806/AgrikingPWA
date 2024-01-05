using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnalysisCategorySequence
{
    public string AnalysisCategoryId { get; set; } = null!;

    public string AnalysisSourceId { get; set; } = null!;

    public int Sequence { get; set; }

    public bool FinalEligable { get; set; }

    public bool Required { get; set; }

    public virtual AnalysisCategory AnalysisCategory { get; set; } = null!;

    public virtual AnalysisSource AnalysisSource { get; set; } = null!;
}
