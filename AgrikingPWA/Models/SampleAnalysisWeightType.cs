using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleAnalysisWeightType
{
    public int Id { get; set; }

    public string? AnalysisTypeId { get; set; }

    public string? Description { get; set; }

    public virtual AnalysisType? AnalysisType { get; set; }

    public virtual ICollection<SampleAnalysisWeight> SampleAnalysisWeights { get; set; } = new List<SampleAnalysisWeight>();
}
