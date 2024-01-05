using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ExportSampleMeta
{
    public int Id { get; set; }

    public string? RecordType { get; set; }

    public string? StartSampleId1 { get; set; }

    public string? EndSampleId1 { get; set; }

    public string? StartSampleId2 { get; set; }

    public string? EndSampleId2 { get; set; }

    public string? StartSampleId3 { get; set; }

    public string? EndSampleId3 { get; set; }
}
