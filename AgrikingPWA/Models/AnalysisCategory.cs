using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnalysisCategory
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public bool ClientVisible { get; set; }

    public bool RationVisible { get; set; }

    public bool NutritionVisible { get; set; }

    public virtual ICollection<AnalysisCategorySequence> AnalysisCategorySequences { get; set; } = new List<AnalysisCategorySequence>();

    public virtual ICollection<AnalysisType> AnalysisTypes { get; set; } = new List<AnalysisType>();
}
