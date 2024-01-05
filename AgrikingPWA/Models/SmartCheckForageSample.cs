using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SmartCheckForageSample
{
    public int Id { get; set; }

    public int? SmartCheckId { get; set; }

    public int? SmartCheckForageId { get; set; }

    public string? SampleId { get; set; }

    public string? EthanolContent { get; set; }

    public string? KernalProcessingScore { get; set; }

    public virtual Sample? Sample { get; set; }

    public virtual SmartCheck? SmartCheck { get; set; }

    public virtual SmartCheckForage? SmartCheckForage { get; set; }

    public virtual ICollection<SmartCheckForageSampleAnalysisValue> SmartCheckForageSampleAnalysisValues { get; set; } = new List<SmartCheckForageSampleAnalysisValue>();
}
