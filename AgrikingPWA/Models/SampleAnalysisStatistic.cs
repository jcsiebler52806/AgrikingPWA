using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleAnalysisStatistic
{
    public string? SampleTypeId { get; set; }

    public string? AnalysisTypeId { get; set; }

    public string? CalendarYear { get; set; }

    public string? CountryId { get; set; }

    public int Count { get; set; }

    public decimal Minimum { get; set; }

    public decimal Maximum { get; set; }

    public decimal Range { get; set; }

    public decimal Mean { get; set; }

    public decimal Variance { get; set; }

    public decimal StandardDeviation { get; set; }

    public int Id { get; set; }

    public string? RegionId { get; set; }

    public string? StateId { get; set; }

    public virtual AnalysisType? AnalysisType { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Region? Region { get; set; }

    public virtual SampleType? SampleType { get; set; }

    public virtual State? State { get; set; }
}
