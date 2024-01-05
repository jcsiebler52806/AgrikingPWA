using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SmartCheckForageImage
{
    public int Id { get; set; }

    public int SmartCheckForageId { get; set; }

    public string? Image { get; set; }

    public bool Infrared { get; set; }

    public string? AnalysisTypeId { get; set; }

    public virtual SmartCheckForage SmartCheckForage { get; set; } = null!;
}
