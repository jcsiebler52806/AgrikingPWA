using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnalysisTypeSourceSequence
{
    public string AnalysisTypeId { get; set; } = null!;

    public string AnalysisSourceId { get; set; } = null!;

    public int Sequence { get; set; }

    public bool FinalEligable { get; set; }

    public bool Required { get; set; }

    public decimal? WetLabCost { get; set; }

    public virtual AnalysisSource AnalysisSource { get; set; } = null!;

    public virtual AnalysisType AnalysisType { get; set; } = null!;
}
