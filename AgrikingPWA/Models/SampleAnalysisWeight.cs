using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleAnalysisWeight
{
    public string SampleId { get; set; } = null!;

    public string? LabContainerTypeId { get; set; }

    public string? LabContainerNumber { get; set; }

    public decimal? ContainerWeight { get; set; }

    public decimal? SampleWeight { get; set; }

    public DateTime? WeighedDateTime { get; set; }

    public int SampleAnalysisWeightTypeId { get; set; }

    public decimal? BaseCalc { get; set; }

    public virtual LabContainer? LabContainer { get; set; }

    public virtual LabContainerType? LabContainerType { get; set; }

    public virtual SampleAnalysisWeightType SampleAnalysisWeightType { get; set; } = null!;
}
