using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ImportTaskLog
{
    public int Id { get; set; }

    public int ImportTaskId { get; set; }

    public string Process { get; set; } = null!;

    public string Step { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Message { get; set; } = null!;

    public virtual ImportTask ImportTask { get; set; } = null!;
}
