using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class LabSpecialAnalysisRequestSample
{
    public string LabSpecialAnalysisRequestId { get; set; } = null!;

    public string SampleId { get; set; } = null!;

    public DateTime? FinalizedDateTime { get; set; }

    public bool Notify { get; set; }

    public bool Report { get; set; }

    public virtual LabSpecialAnalysisRequest LabSpecialAnalysisRequest { get; set; } = null!;

    public virtual Sample Sample { get; set; } = null!;
}
