using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnalysisNonNumericResult
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public bool AllowEntry { get; set; }

    public string? AnalysisSourceId { get; set; }

    public virtual ICollection<AnalysisNonNumericResultOption> AnalysisNonNumericResultOptions { get; set; } = new List<AnalysisNonNumericResultOption>();

    public virtual AnalysisSource? AnalysisSource { get; set; }

    public virtual ICollection<AnalysisType> AnalysisTypes { get; set; } = new List<AnalysisType>();
}
