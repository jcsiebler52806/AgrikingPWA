using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SmartCheckAnalysisType
{
    public int Id { get; set; }

    public string? AnalysisTypeId { get; set; }

    public bool RequiredForage { get; set; }

    public bool RequiredGrain { get; set; }

    public string? SampleTypeId { get; set; }

    public virtual AnalysisType? AnalysisType { get; set; }

    public virtual SampleType? SampleType { get; set; }
}
