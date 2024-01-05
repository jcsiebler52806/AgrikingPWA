using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class RationCategory
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Ration> Rations { get; set; } = new List<Ration>();
}
