using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Sample
{
    public string Id { get; set; } = null!;

    public string? CustomerId { get; set; }

    public string? SampleTypeId { get; set; }

    public string? SampleStatusId { get; set; }

    public string? Description { get; set; }

    public string? LabPackageId { get; set; }

    public DateTime? EnteredDateTime { get; set; }

    public DateTime? TransferredDateTime { get; set; }

    public DateTime? SetupDateTime { get; set; }

    public DateTime? RationizedDateTime { get; set; }

    public DateTime? FinalizedDateTime { get; set; }

    public DateTime? WetDestroyedDateTime { get; set; }

    public DateTime? DryDestroyedDateTime { get; set; }

    public DateTime? VerifyDestroyedDateTime { get; set; }

    public bool SiloKingTreated { get; set; }

    public bool DestroyRequired { get; set; }

    public string? Image { get; set; }

    public string? DryDestroyedUserId { get; set; }

    public string? VerifyDestroyedUserId { get; set; }

    public string? WetDestroyedUserId { get; set; }

    public DateTime? LabApprovedDateTime { get; set; }

    public bool ReturnCup { get; set; }

    public bool Icphold { get; set; }

    public DateTime? InstrumentationApprovedDateTime { get; set; }

    public DateTime? ProcessDateTime { get; set; }

    public string? ExportDescription { get; set; }

    public DateTime? NirfinalizedDateTime { get; set; }

    public DateTime? XryfinalizedDateTime { get; set; }

    public DateTime? WetLabReleasedDateTime { get; set; }

    public DateTime? InstrumentationReleasedDateTime { get; set; }

    public DateTime? ReRunReleasedDateTime { get; set; }

    public bool? Hold { get; set; }

    public bool? NotificationSent { get; set; }

    public DateTime? VerifyDestroyedReportSentDateTime { get; set; }

    public virtual Customer? Customer { get; set; }
    public SampleRequest? SampleRequest { get; set; }

    public virtual LabPackage? LabPackage { get; set; }

    public virtual ICollection<LabSpecialAnalysisRequestSample> LabSpecialAnalysisRequestSamples { get; set; } = new List<LabSpecialAnalysisRequestSample>();

    public virtual ICollection<SampleAnalysisFinalValueImport> SampleAnalysisFinalValueImports { get; set; } = new List<SampleAnalysisFinalValueImport>();

    public virtual ICollection<SampleAnalysisFinalValue> SampleAnalysisFinalValues { get; set; } = new List<SampleAnalysisFinalValue>();

    public virtual ICollection<SampleAnalysisWorkingValue> SampleAnalysisWorkingValues { get; set; } = new List<SampleAnalysisWorkingValue>();

    public virtual ICollection<SampleParticleSizeAnalysis> SampleParticleSizeAnalyses { get; set; } = new List<SampleParticleSizeAnalysis>();

    public virtual SampleStatus? SampleStatus { get; set; }

    public virtual SampleType? SampleType { get; set; }

    public virtual ICollection<SmartCheckForageSampleAnalysisValue> SmartCheckForageSampleAnalysisValues { get; set; } = new List<SmartCheckForageSampleAnalysisValue>();

    public virtual ICollection<SmartCheckForageSample> SmartCheckForageSamples { get; set; } = new List<SmartCheckForageSample>();
}
