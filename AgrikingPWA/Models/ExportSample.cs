using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ExportSample
{
    public int Id { get; set; }

    public string? RecordType { get; set; }

    public string? SampleId { get; set; }

    public string? ClientId { get; set; }

    public string? SampleTypeId { get; set; }

    public string? Description { get; set; }

    public bool SiloKingTreated { get; set; }

    public string? Status { get; set; }

    public string? PackageId { get; set; }

    public string? EnteredDate { get; set; }

    public string? SetupDate { get; set; }

    public string? RationDate { get; set; }

    public string? FinalDate { get; set; }
}
