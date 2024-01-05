using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnalysisNonNumericResultOption
{
    public int Id { get; set; }

    public int AnalysisNonNumericResultId { get; set; }

    public string? DisplayText { get; set; }

    public decimal? LowRangeValue { get; set; }

    public decimal? HighRangeValue { get; set; }

    public virtual AnalysisNonNumericResult AnalysisNonNumericResult { get; set; } = null!;
}
