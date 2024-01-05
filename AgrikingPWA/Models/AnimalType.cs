using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnimalType
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<AnimalBreed> AnimalBreeds { get; set; } = new List<AnimalBreed>();

    public virtual ICollection<RationType> RationTypes { get; set; } = new List<RationType>();

    public virtual ICollection<Ration> Rations { get; set; } = new List<Ration>();

    public virtual ICollection<SampleAnalysisTargetValue> SampleAnalysisTargetValues { get; set; } = new List<SampleAnalysisTargetValue>();

    public virtual ICollection<SampleRequest> SampleRequests { get; set; } = new List<SampleRequest>();
}
