using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ItemFulfillmentDetail
{
    public int Id { get; set; }

    public int ItemFulfillmentId { get; set; }

    public DateTime? FulfillmentDateTime { get; set; }

    public string? SalespersonId { get; set; }

    public string? TruckId { get; set; }

    public string? TruckDropId { get; set; }

    public string? ItemId { get; set; }

    public int? UnitId { get; set; }

    public string? UnitTypeId { get; set; }

    public string? LotNumber { get; set; }

    public double Quantity { get; set; }

    public double ItemWeight { get; set; }

    public double ShippedWeight { get; set; }

    public int? NstruckDropId { get; set; }

    public int? NstruckId { get; set; }

    public virtual Item? Item { get; set; }

    public virtual ItemFulfillment ItemFulfillment { get; set; } = null!;

    public virtual Nstruck? Nstruck { get; set; }

    public virtual NstruckDrop? NstruckDrop { get; set; }

    public virtual Salesperson? Salesperson { get; set; }

    public virtual Truck? Truck { get; set; }

    public virtual TruckDrop? TruckDrop { get; set; }

    public virtual Unit? Unit { get; set; }

    public virtual UnitType? UnitType { get; set; }
}
