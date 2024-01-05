using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SalesOrderDetail
{
    public int Id { get; set; }

    public string? SalesOrderId { get; set; }

    public string? PriceLevelId { get; set; }

    public string? ItemId { get; set; }

    public int? UnitId { get; set; }

    public string? UnitTypeId { get; set; }

    public double UnitPrice { get; set; }

    public double OverridePrice { get; set; }

    public double Quantity { get; set; }

    public double ItemAmount { get; set; }

    public int LineNumber { get; set; }

    public string? Lot { get; set; }

    public virtual Item? Item { get; set; }

    public virtual PriceLevel? PriceLevel { get; set; }

    public virtual SalesOrder? SalesOrder { get; set; }

    public virtual Unit? Unit { get; set; }

    public virtual UnitType? UnitType { get; set; }
}
