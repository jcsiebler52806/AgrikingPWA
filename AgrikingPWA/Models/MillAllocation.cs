using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class MillAllocation
{
    public int Id { get; set; }

    public string? Memo { get; set; }

    public string? PriceLevelId { get; set; }

    public DateTime? AllocationDate { get; set; }

    public string? MillId { get; set; }

    public string? CurrencyId { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual Customer? Mill { get; set; }

    public virtual ICollection<MillAllocationDetail> MillAllocationDetails { get; set; } = new List<MillAllocationDetail>();

    public virtual PriceLevel? PriceLevel { get; set; }
}
