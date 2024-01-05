using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SalesOrderDetailLot
{
    public int Id { get; set; }

    public string? SalesOrderId { get; set; }

    public string? ItemId { get; set; }

    public int LineNumber { get; set; }

    public string? Lot { get; set; }

    public double Quantity { get; set; }

    public virtual Item? Item { get; set; }

    public virtual SalesOrder? SalesOrder { get; set; }
}
