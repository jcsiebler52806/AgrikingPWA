using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class MillAllocationDetailItem
{
    public int Id { get; set; }

    public string? ItemId { get; set; }

    public decimal Quantity { get; set; }

    public int? UnitId { get; set; }

    public double UnitPrice { get; set; }

    public double ItemAmount { get; set; }

    public int MadetailId { get; set; }

    public int LineNumber { get; set; }

    public string? PriceLevelId { get; set; }

    public string? UnitTypeId { get; set; }

    public virtual Item? Item { get; set; }

    public virtual MillAllocationDetail Madetail { get; set; } = null!;

    public virtual PriceLevel? PriceLevel { get; set; }

    public virtual Unit? Unit { get; set; }

    public virtual UnitType? UnitType { get; set; }
}
