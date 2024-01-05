using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnalysisGroup
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<AnalysisType> AnalysisTypes { get; set; } = new List<AnalysisType>();
}
