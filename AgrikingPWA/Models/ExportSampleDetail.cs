using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ExportSampleDetail
{
    public int Id { get; set; }

    public string? RecordType { get; set; }

    public string? SampleId { get; set; }

    public string? AnalysisId { get; set; }

    public decimal FinalValue { get; set; }

    public decimal AsAnalyzedValue { get; set; }

    public string? AnalysisSourceId { get; set; }
}
