using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleCategory
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public bool AnalyzeDry { get; set; }

    public virtual ICollection<SampleCategoryAnalysisType> SampleCategoryAnalysisTypes { get; set; } = new List<SampleCategoryAnalysisType>();

    public virtual ICollection<SampleType> SampleTypes { get; set; } = new List<SampleType>();
}
