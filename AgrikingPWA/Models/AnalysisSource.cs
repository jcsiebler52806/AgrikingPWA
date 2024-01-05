using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnalysisSource
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string? ProcessTypeId { get; set; }

    public int Sequence { get; set; }

    public string? ExportClass { get; set; }

    public string? ImportClass { get; set; }

    public bool Active { get; set; }

    public bool Available { get; set; }

    public virtual ICollection<AnalysisCategorySequence> AnalysisCategorySequences { get; set; } = new List<AnalysisCategorySequence>();

    public virtual AnalysisNonNumericResult? AnalysisNonNumericResult { get; set; }

    public virtual ICollection<AnalysisSourceExclusion> AnalysisSourceExclusions { get; set; } = new List<AnalysisSourceExclusion>();

    public virtual ICollection<AnalysisTypeSourceSequence> AnalysisTypeSourceSequences { get; set; } = new List<AnalysisTypeSourceSequence>();

    public virtual AnalysisProcessType? ProcessType { get; set; }

    public virtual ICollection<SampleAnalysisFinalValueImport> SampleAnalysisFinalValueImports { get; set; } = new List<SampleAnalysisFinalValueImport>();

    public virtual ICollection<SampleAnalysisFinalValue> SampleAnalysisFinalValues { get; set; } = new List<SampleAnalysisFinalValue>();

    public virtual ICollection<SampleAnalysisLimit> SampleAnalysisLimits { get; set; } = new List<SampleAnalysisLimit>();

    public virtual ICollection<SampleAnalysisWorkingValue> SampleAnalysisWorkingValues { get; set; } = new List<SampleAnalysisWorkingValue>();

    public virtual ICollection<SampleTypeAnalysisTypeSourceSequence> SampleTypeAnalysisTypeSourceSequences { get; set; } = new List<SampleTypeAnalysisTypeSourceSequence>();

    public virtual ICollection<SmartCheckForageSampleAnalysisValue> SmartCheckForageSampleAnalysisValues { get; set; } = new List<SmartCheckForageSampleAnalysisValue>();
}
