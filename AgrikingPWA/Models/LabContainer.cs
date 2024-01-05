using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class LabContainer
{
    public string LabContainerTypeId { get; set; } = null!;

    public string Number { get; set; } = null!;

    public decimal Weight { get; set; }

    public DateTime? LastWeighedDate { get; set; }

    public virtual LabContainerType LabContainerType { get; set; } = null!;

    public virtual ICollection<SampleAnalysisWeight> SampleAnalysisWeights { get; set; } = new List<SampleAnalysisWeight>();

    public virtual ICollection<SampleMoistureWeight> SampleMoistureWeights { get; set; } = new List<SampleMoistureWeight>();
}
