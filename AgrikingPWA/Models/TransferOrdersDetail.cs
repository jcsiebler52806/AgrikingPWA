using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class TransferOrdersDetail
{
    public int Id { get; set; }

    public int NetSuiteId { get; set; }

    public int TransferOrderId { get; set; }

    public int LineNumber { get; set; }

    public string? ItemId { get; set; }

    public int UnitId { get; set; }

    public string? UnitTypeId { get; set; }

    public double Quantity { get; set; }

    public virtual Item? Item { get; set; }

    public virtual TransferOrder TransferOrder { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;

    public virtual UnitType? UnitType { get; set; }
}
