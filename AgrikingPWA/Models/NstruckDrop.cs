﻿using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class NstruckDrop
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? LegacyId { get; set; }

    public string? DisplayName { get; set; }

    public int TruckId { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? CountryId { get; set; }

    public bool Inactive { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public int Sequence { get; set; }

    public string? LegacyTruckId { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<ItemFulfillmentDetail> ItemFulfillmentDetails { get; set; } = new List<ItemFulfillmentDetail>();

    public virtual ICollection<ItemFulfillment> ItemFulfillments { get; set; } = new List<ItemFulfillment>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public virtual ICollection<Salesperson> Salespeople { get; set; } = new List<Salesperson>();

    public virtual ICollection<TransferOrder> TransferOrders { get; set; } = new List<TransferOrder>();

    public virtual Nstruck Truck { get; set; } = null!;
}
