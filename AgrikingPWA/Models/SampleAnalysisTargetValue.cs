using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleAnalysisTargetValue
{
    public string? CountryId { get; set; }

    public string? SampleTypeId { get; set; }

    public string? AnalysisTypeId { get; set; }

    public string? RationTypeId { get; set; }

    public decimal? TargetValue { get; set; }

    public decimal? LowValue { get; set; }

    public decimal? VeryLowValue { get; set; }

    public decimal? HighValue { get; set; }

    public decimal? VeryHighValue { get; set; }

    public bool? LowValueAdverse { get; set; }

    public bool? HighValueAdverse { get; set; }

    public bool? LowValueAlert { get; set; }

    public bool? VeryLowValueAlert { get; set; }

    public bool? HighValueAlert { get; set; }

    public bool? VeryHighValueAlert { get; set; }

    public int Id { get; set; }

    public string? AnimalTypeId { get; set; }

    public virtual AnalysisType? AnalysisType { get; set; }

    public virtual AnimalType? AnimalType { get; set; }

    public virtual Country? Country { get; set; }

    public virtual RationType? RationType { get; set; }

    public virtual SampleType? SampleType { get; set; }
}
