using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SmartCheckForage
{
    public int Id { get; set; }

    public int SmartCheckId { get; set; }

    public string? Description { get; set; }

    public DateTime? HarvestedDateTime { get; set; }

    public string? AmbientHighTemp { get; set; }

    public double SugarContent { get; set; }

    public bool Organic { get; set; }

    public string? TreatedWith { get; set; }

    public string? TreatmentRate { get; set; }

    public string? TreatmentCost { get; set; }

    public string? WeedControlProgramNote { get; set; }

    public string? SidewallLining { get; set; }

    public string? StretchBarMeasurements { get; set; }

    public string? DensityDepthA { get; set; }

    public string? DensityDepthB { get; set; }

    public string? DensityDepthC { get; set; }

    public string? DensityDepthD { get; set; }

    public string? BunkerDiameter { get; set; }

    public string? BunkerLength { get; set; }

    public string? BunkerWidth { get; set; }

    public string? CoverApplicationNote { get; set; }

    public string? CoverType { get; set; }

    public string? DiseaseControlProgramNote { get; set; }

    public string? FaceManagementNote { get; set; }

    public string? FertilizerProgramNote { get; set; }

    public string? InsectControlProgramNote { get; set; }

    public string? SeedPopulation { get; set; }

    public string? SeedRowWidth { get; set; }

    public string? SeedVariety { get; set; }

    public DateTime? SmartCheckTempDateTime { get; set; }

    public string? KernalProcessingScore { get; set; }

    public string? EthanolContent { get; set; }

    public string? Agronomist { get; set; }

    public string? BunkerFloorType { get; set; }

    public string? FaceRemovalDailyRate { get; set; }

    public string? GeneralComments { get; set; }

    public string? DensitySampleA { get; set; }

    public string? DensitySampleB { get; set; }

    public string? DensitySampleC { get; set; }

    public string? DensitySampleD { get; set; }

    public string? DensityWeightA { get; set; }

    public string? DensityWeightB { get; set; }

    public string? DensityWeightC { get; set; }

    public string? DensityWeightD { get; set; }

    public string? DensityImage { get; set; }

    public string? ForageImage1 { get; set; }

    public string? ForageImage2 { get; set; }

    public string? ThermalImage1 { get; set; }

    public string? ThermalImage2 { get; set; }

    public decimal CalculatedDensityA { get; set; }

    public decimal CalculatedDensityB { get; set; }

    public decimal CalculatedDensityC { get; set; }

    public decimal CalculatedDensityD { get; set; }

    public virtual SmartCheck SmartCheck { get; set; } = null!;

    public virtual ICollection<SmartCheckForageImage> SmartCheckForageImages { get; set; } = new List<SmartCheckForageImage>();

    public virtual ICollection<SmartCheckForageSample> SmartCheckForageSamples { get; set; } = new List<SmartCheckForageSample>();

    public virtual ICollection<SmartCheckForageTemperature> SmartCheckForageTemperatures { get; set; } = new List<SmartCheckForageTemperature>();
}
