using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleRequest
{
    public string Id { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string? SalespersonId { get; set; }

    public string? SampleTypeId { get; set; }

    public string? Description { get; set; }

    public string? Comment { get; set; }

    public DateTime? EnteredDateTime { get; set; }

    public DateTime? UploadedDateTime { get; set; }

    public DateTime? ReceivedDateTime { get; set; }

    public bool SiloKingTreated { get; set; }

    public bool TestOnly { get; set; }

    public bool WorkRation { get; set; }

    public bool SendToClient { get; set; }

    public bool SendToSalesperson { get; set; }

    public bool ToxinScreenRequested { get; set; }

    public bool ParticleSizeRequested { get; set; }

    public string? RationId { get; set; }

    public string? SampleId { get; set; }

    public bool SmartCheckRequested { get; set; }

    public string? AnimalTypeId { get; set; }

    public string? RationTypeId { get; set; }

    public bool MoistureOnly { get; set; }

    public string? ProspectAddress { get; set; }

    public bool? ProspectFlag { get; set; }

    public string? ProspectName { get; set; }

    public virtual AnimalType? AnimalType { get; set; }

    public virtual RationType? RationType { get; set; }

    public virtual Salesperson? Salesperson { get; set; }

    public virtual SampleType? SampleType { get; set; }
}
