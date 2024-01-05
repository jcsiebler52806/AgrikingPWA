using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleCategoryAnalysisType
{
    public string SampleCategoryId { get; set; } = null!;

    public string AnalysisTypeId { get; set; } = null!;

    public bool RequiredRations { get; set; }

    public bool RequiredFinal { get; set; }

    public decimal? HighLimitValue { get; set; }

    public decimal? LowLimitValue { get; set; }

    public decimal? StandardValue { get; set; }

    public virtual AnalysisType AnalysisType { get; set; } = null!;

    public virtual SampleCategory SampleCategory { get; set; } = null!;
}
