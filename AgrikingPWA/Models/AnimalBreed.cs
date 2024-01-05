using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnimalBreed
{
    public string AnimalTypeId { get; set; } = null!;

    public string AnimalBreedId { get; set; } = null!;

    public string? Description { get; set; }

    public virtual AnimalType AnimalType { get; set; } = null!;

    public virtual ICollection<Ration> Rations { get; set; } = new List<Ration>();
}
