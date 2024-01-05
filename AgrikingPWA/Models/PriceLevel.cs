using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class PriceLevel
{
    public string Id { get; set; } = null!;

    public string? NetSuiteId { get; set; }

    public string? DisplayName { get; set; }

    public bool Inactive { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<ItemPricePeriod> ItemPricePeriods { get; set; } = new List<ItemPricePeriod>();

    public virtual ICollection<ItemPrice> ItemPrices { get; set; } = new List<ItemPrice>();

    public virtual ICollection<MillAllocationDetailItem> MillAllocationDetailItems { get; set; } = new List<MillAllocationDetailItem>();

    public virtual ICollection<MillAllocation> MillAllocations { get; set; } = new List<MillAllocation>();

    public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; } = new List<SalesOrderDetail>();

    public virtual ICollection<Salesperson> Salespeople { get; set; } = new List<Salesperson>();
}
