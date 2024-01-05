using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ItemFulfillment
{
    public int Id { get; set; }

    public string? TransactionId { get; set; }

    public string? SalesOrderId { get; set; }

    public string? TransferOrderId { get; set; }

    public string? NetSuiteId { get; set; }

    public DateTime? FulfillmentDateTime { get; set; }

    public string? SalespersonId { get; set; }

    public string? TruckId { get; set; }

    public string? TruckDropId { get; set; }

    public int? NstruckDropId { get; set; }

    public int? NstruckId { get; set; }

    public virtual ICollection<ItemFulfillmentDetail> ItemFulfillmentDetails { get; set; } = new List<ItemFulfillmentDetail>();

    public virtual Nstruck? Nstruck { get; set; }

    public virtual NstruckDrop? NstruckDrop { get; set; }

    public virtual SalesOrder? SalesOrder { get; set; }

    public virtual Salesperson? Salesperson { get; set; }

    public virtual Truck? Truck { get; set; }

    public virtual TruckDrop? TruckDrop { get; set; }
}
