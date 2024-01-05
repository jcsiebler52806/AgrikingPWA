using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleStatus
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public bool ProcessHold { get; set; }

    public virtual ICollection<Sample> Samples { get; set; } = new List<Sample>();
}
