using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Nstruck
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? LegacyId { get; set; }

    public string? DisplayName { get; set; }

    public string? InvoiceDescription { get; set; }

    public double Capacity { get; set; }

    public bool Inactive { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<ItemFulfillmentDetail> ItemFulfillmentDetails { get; set; } = new List<ItemFulfillmentDetail>();

    public virtual ICollection<ItemFulfillment> ItemFulfillments { get; set; } = new List<ItemFulfillment>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<NstruckDrop> NstruckDrops { get; set; } = new List<NstruckDrop>();

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public virtual ICollection<Salesperson> Salespeople { get; set; } = new List<Salesperson>();

    public virtual ICollection<TransferOrder> TransferOrders { get; set; } = new List<TransferOrder>();

    public virtual ICollection<TruckDefault> TruckDefaults { get; set; } = new List<TruckDefault>();

    public virtual ICollection<TruckException> TruckExceptions { get; set; } = new List<TruckException>();

    public virtual ICollection<TruckFinal> TruckFinals { get; set; } = new List<TruckFinal>();
}
