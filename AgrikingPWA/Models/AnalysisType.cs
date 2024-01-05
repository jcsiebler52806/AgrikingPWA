using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnalysisType
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string? CategoryId { get; set; }

    public string Abbreviation { get; set; } = null!;

    public string? UnitOfMeasureId { get; set; }

    public int Decimals { get; set; }

    public string? MoistureFactor { get; set; }

    public string? CalculationClass { get; set; }

    public bool ClientVisible { get; set; }

    public bool RationVisible { get; set; }

    public bool NutritionVisible { get; set; }

    public bool PackageVisible { get; set; }

    public bool SpecialAnalysisVisible { get; set; }

    public bool RequiredRations { get; set; }

    public bool RequiredFinal { get; set; }

    public bool? HighValueAdverse { get; set; }

    public bool? HighValueAlert { get; set; }

    public bool? LowValueAdverse { get; set; }

    public bool? LowValueAlert { get; set; }

    public bool? VeryHighValueAlert { get; set; }

    public bool? VeryLowValueAlert { get; set; }

    public int? NonNumericResultId { get; set; }

    public int? CalculationLevel { get; set; }

    public bool? SpecialAnalysisReport { get; set; }

    public bool? ToxinReport { get; set; }

    public virtual ICollection<AnalysisCalculationReference> AnalysisCalculationReferences { get; set; } = new List<AnalysisCalculationReference>();

    public virtual ICollection<AnalysisSourceExclusion> AnalysisSourceExclusions { get; set; } = new List<AnalysisSourceExclusion>();

    public virtual ICollection<AnalysisTypeSourceSequence> AnalysisTypeSourceSequences { get; set; } = new List<AnalysisTypeSourceSequence>();

    public virtual AnalysisCategory? Category { get; set; }

    public virtual ICollection<LabPackageAnalysis> LabPackageAnalyses { get; set; } = new List<LabPackageAnalysis>();

    public virtual ICollection<LabSlopeIntercept> LabSlopeIntercepts { get; set; } = new List<LabSlopeIntercept>();

    public virtual ICollection<LabSpecialAnalysisRequestAnalysis> LabSpecialAnalysisRequestAnalyses { get; set; } = new List<LabSpecialAnalysisRequestAnalysis>();

    public virtual ICollection<LabXrayCorrection> LabXrayCorrectionAnalysisTypes { get; set; } = new List<LabXrayCorrection>();

    public virtual ICollection<LabXrayCorrection> LabXrayCorrectionCorrectionAnalysisTypes { get; set; } = new List<LabXrayCorrection>();

    public virtual AnalysisNonNumericResult? NonNumericResult { get; set; }

    public virtual ICollection<SampleAnalysisFinalValueImport> SampleAnalysisFinalValueImports { get; set; } = new List<SampleAnalysisFinalValueImport>();

    public virtual ICollection<SampleAnalysisFinalValue> SampleAnalysisFinalValues { get; set; } = new List<SampleAnalysisFinalValue>();

    public virtual ICollection<SampleAnalysisLimit> SampleAnalysisLimits { get; set; } = new List<SampleAnalysisLimit>();

    public virtual ICollection<SampleAnalysisReportRange> SampleAnalysisReportRanges { get; set; } = new List<SampleAnalysisReportRange>();

    public virtual ICollection<SampleAnalysisStatistic> SampleAnalysisStatistics { get; set; } = new List<SampleAnalysisStatistic>();

    public virtual ICollection<SampleAnalysisTargetValue> SampleAnalysisTargetValues { get; set; } = new List<SampleAnalysisTargetValue>();

    public virtual ICollection<SampleAnalysisWeightType> SampleAnalysisWeightTypes { get; set; } = new List<SampleAnalysisWeightType>();

    public virtual ICollection<SampleAnalysisWorkingValue> SampleAnalysisWorkingValues { get; set; } = new List<SampleAnalysisWorkingValue>();

    public virtual ICollection<SampleCategoryAnalysisType> SampleCategoryAnalysisTypes { get; set; } = new List<SampleCategoryAnalysisType>();

    public virtual ICollection<SampleParticleSizeAnalysis> SampleParticleSizeAnalyses { get; set; } = new List<SampleParticleSizeAnalysis>();

    public virtual ICollection<SampleTypeAnalysisTypeSourceSequence> SampleTypeAnalysisTypeSourceSequences { get; set; } = new List<SampleTypeAnalysisTypeSourceSequence>();

    public virtual ICollection<SampleTypeAnalysisType> SampleTypeAnalysisTypes { get; set; } = new List<SampleTypeAnalysisType>();

    public virtual ICollection<SmartCheckAnalysisType> SmartCheckAnalysisTypes { get; set; } = new List<SmartCheckAnalysisType>();

    public virtual ICollection<SmartCheckForageSampleAnalysisValue> SmartCheckForageSampleAnalysisValues { get; set; } = new List<SmartCheckForageSampleAnalysisValue>();

    public virtual AnalysisUnitsOfMeasure? UnitOfMeasure { get; set; }

    public virtual ICollection<AnalysisGroup> AnalysisGroups { get; set; } = new List<AnalysisGroup>();
}
