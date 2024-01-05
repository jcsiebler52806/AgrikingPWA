using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleResultExportTemplate
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? AnalysisTypes { get; set; }

    public string? Source { get; set; }

    public string? Corrected { get; set; }

    public string? UserId { get; set; }

    public virtual User? User { get; set; }
}
