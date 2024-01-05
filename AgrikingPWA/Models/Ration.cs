using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Ration
{
    public string Id { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string? AnimalBreedId { get; set; }

    public int AnimalCount { get; set; }

    public string? AnimalDescription { get; set; }

    public decimal AnimalProduction { get; set; }

    public string? AnimalTypeId { get; set; }

    public decimal AnimalWeight { get; set; }

    public string? Description { get; set; }

    public string? RationCategoryId { get; set; }

    public string? RationTypeId { get; set; }

    public DateTime? FinalizedDateTime { get; set; }

    public string? AnimalBreedAnimalTypeId { get; set; }

    public string? AnimalBreedId1 { get; set; }

    public virtual AnimalBreed? Animal { get; set; }

    public virtual AnimalType? AnimalType { get; set; }

    public virtual RationCategory? RationCategory { get; set; }

    public virtual RationType? RationType { get; set; }
}
