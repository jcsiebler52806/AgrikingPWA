using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SmartCheck
{
    public int Id { get; set; }

    public string? CustomerId { get; set; }

    public DateTime? EnteredDateTime { get; set; }

    public DateTime? FinalizedDateTime { get; set; }

    public string? CustomerNarrative { get; set; }

    public string? Description { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<SmartCheckEmployee> SmartCheckEmployees { get; set; } = new List<SmartCheckEmployee>();

    public virtual ICollection<SmartCheckForageSample> SmartCheckForageSamples { get; set; } = new List<SmartCheckForageSample>();

    public virtual ICollection<SmartCheckForage> SmartCheckForages { get; set; } = new List<SmartCheckForage>();
}
