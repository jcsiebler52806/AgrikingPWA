using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class MillAllocationType
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<MillAllocationAssociation> MillAllocationAssociations { get; set; } = new List<MillAllocationAssociation>();
}
