using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class XrayCalibrationCategory
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<SampleType> SampleTypes { get; set; } = new List<SampleType>();
}
