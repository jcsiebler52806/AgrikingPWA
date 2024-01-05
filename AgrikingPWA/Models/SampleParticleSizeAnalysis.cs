using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleParticleSizeAnalysis
{
    public string SampleId { get; set; } = null!;

    public string AnalysisTypeId { get; set; } = null!;

    public decimal BeforeWeight { get; set; }

    public decimal AfterWeight { get; set; }

    public virtual AnalysisType AnalysisType { get; set; } = null!;

    public virtual Sample Sample { get; set; } = null!;
}
