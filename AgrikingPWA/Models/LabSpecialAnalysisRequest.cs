using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class LabSpecialAnalysisRequest
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string CustomerId { get; set; } = null!;

    public DateTime? EndDate { get; set; }

    public int? SampleCount { get; set; }

    public string? SampleId { get; set; }

    public string? SampleRequestId { get; set; }

    public DateTime? StartDate { get; set; }

    public string? UserId { get; set; }

    public bool Active { get; set; }

    public bool SendEmail { get; set; }

    public bool ReturnCup { get; set; }

    public DateTime? EnteredDateTime { get; set; }

    public virtual ICollection<LabSpecialAnalysisRequestAnalysis> LabSpecialAnalysisRequestAnalyses { get; set; } = new List<LabSpecialAnalysisRequestAnalysis>();

    public virtual ICollection<LabSpecialAnalysisRequestSample> LabSpecialAnalysisRequestSamples { get; set; } = new List<LabSpecialAnalysisRequestSample>();

    public virtual User? User { get; set; }

    public virtual ICollection<SampleType> SampleTypes { get; set; } = new List<SampleType>();
}
