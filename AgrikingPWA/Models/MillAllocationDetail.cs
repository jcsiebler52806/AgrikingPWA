using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class MillAllocationDetail
{
    public int Id { get; set; }

    public string? LegacyId { get; set; }

    public bool IsOffset { get; set; }

    public string? CustomerId { get; set; }

    public int Maid { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual MillAllocation Ma { get; set; } = null!;

    public virtual ICollection<MillAllocationDetailItem> MillAllocationDetailItems { get; set; } = new List<MillAllocationDetailItem>();
}
