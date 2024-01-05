using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class RationType
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string? AnimalTypeId { get; set; }

    public virtual AnimalType? AnimalType { get; set; }

    public virtual ICollection<Ration> Rations { get; set; } = new List<Ration>();

    public virtual ICollection<SampleAnalysisTargetValue> SampleAnalysisTargetValues { get; set; } = new List<SampleAnalysisTargetValue>();

    public virtual ICollection<SampleRequest> SampleRequests { get; set; } = new List<SampleRequest>();
}
