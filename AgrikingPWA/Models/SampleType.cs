using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleType
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string? CategoryId { get; set; }

    public string? ExportTypeId { get; set; }

    public string? ExportDescription { get; set; }

    public bool Active { get; set; }

    public bool Ration { get; set; }

    public string? XrayCalibrationCategoryId { get; set; }

    public string? CalculationTypeId { get; set; }

    public virtual ICollection<AnalysisCalculationReference> AnalysisCalculationReferences { get; set; } = new List<AnalysisCalculationReference>();

    public virtual SampleCategory? Category { get; set; }

    public virtual ICollection<LabSlopeIntercept> LabSlopeIntercepts { get; set; } = new List<LabSlopeIntercept>();

    public virtual ICollection<LabXrayCorrection> LabXrayCorrections { get; set; } = new List<LabXrayCorrection>();

    public virtual ICollection<SampleAnalysisLimit> SampleAnalysisLimits { get; set; } = new List<SampleAnalysisLimit>();

    public virtual ICollection<SampleAnalysisReportRange> SampleAnalysisReportRanges { get; set; } = new List<SampleAnalysisReportRange>();

    public virtual ICollection<SampleAnalysisStatistic> SampleAnalysisStatistics { get; set; } = new List<SampleAnalysisStatistic>();

    public virtual ICollection<SampleAnalysisTargetValue> SampleAnalysisTargetValues { get; set; } = new List<SampleAnalysisTargetValue>();

    public virtual ICollection<SampleRequest> SampleRequests { get; set; } = new List<SampleRequest>();

    public virtual ICollection<SampleTypeAnalysisTypeSourceSequence> SampleTypeAnalysisTypeSourceSequences { get; set; } = new List<SampleTypeAnalysisTypeSourceSequence>();

    public virtual ICollection<SampleTypeAnalysisType> SampleTypeAnalysisTypes { get; set; } = new List<SampleTypeAnalysisType>();

    public virtual ICollection<Sample> Samples { get; set; } = new List<Sample>();

    public virtual ICollection<SmartCheckAnalysisType> SmartCheckAnalysisTypes { get; set; } = new List<SmartCheckAnalysisType>();

    public virtual XrayCalibrationCategory? XrayCalibrationCategory { get; set; }

    public virtual ICollection<LabSpecialAnalysisRequest> LabSpecialAnalysisRequests { get; set; } = new List<LabSpecialAnalysisRequest>();
}
