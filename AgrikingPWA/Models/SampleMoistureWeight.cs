using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleMoistureWeight
{
    public string SampleId { get; set; } = null!;

    public string? LabContainerTypeId { get; set; }

    public string? LabContainerNumber { get; set; }

    public decimal? ContainerWeight { get; set; }

    public decimal? SampleWetWeight { get; set; }

    public decimal? SampleDryWeight { get; set; }

    public decimal? PercentMoisture { get; set; }

    public DateTime? WeighedWetDateTime { get; set; }

    public DateTime? WeighedDryDateTime { get; set; }

    public DateTime? TransferredDateTime { get; set; }

    public virtual LabContainer? LabContainer { get; set; }

    public virtual LabContainerType? LabContainerType { get; set; }
}
