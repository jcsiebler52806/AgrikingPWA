using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class LabContainerType
{
    public string Id { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<LabContainer> LabContainers { get; set; } = new List<LabContainer>();

    public virtual ICollection<SampleAnalysisWeight> SampleAnalysisWeights { get; set; } = new List<SampleAnalysisWeight>();

    public virtual ICollection<SampleMoistureWeight> SampleMoistureWeights { get; set; } = new List<SampleMoistureWeight>();
}
