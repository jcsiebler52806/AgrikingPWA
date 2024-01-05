using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Unit
{
    public string? NetSuiteId { get; set; }

    public string? UnitTypeId { get; set; }

    public string? Name { get; set; }

    public string? PluralName { get; set; }

    public string? Abbreviation { get; set; }

    public string? PluralAbbreviation { get; set; }

    public double ConversionRate { get; set; }

    public int Id { get; set; }

    public virtual ICollection<CreditMemoDetail> CreditMemoDetails { get; set; } = new List<CreditMemoDetail>();

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    public virtual ICollection<Item> ItemBaseUnits { get; set; } = new List<Item>();

    public virtual ICollection<ItemFulfillmentDetail> ItemFulfillmentDetails { get; set; } = new List<ItemFulfillmentDetail>();

    public virtual ICollection<Item> ItemPurchaseUnits { get; set; } = new List<Item>();

    public virtual ICollection<Item> ItemSaleUnits { get; set; } = new List<Item>();

    public virtual ICollection<Item> ItemStockUnits { get; set; } = new List<Item>();

    public virtual ICollection<MillAllocationDetailItem> MillAllocationDetailItems { get; set; } = new List<MillAllocationDetailItem>();

    public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; } = new List<SalesOrderDetail>();

    public virtual ICollection<TransferOrdersDetail> TransferOrdersDetails { get; set; } = new List<TransferOrdersDetail>();

    public virtual UnitType? UnitType { get; set; }

    public virtual ICollection<WorkOrderBatchAssembly> WorkOrderBatchAssemblies { get; set; } = new List<WorkOrderBatchAssembly>();

    public virtual ICollection<WorkOrderBatch> WorkOrderBatches { get; set; } = new List<WorkOrderBatch>();

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
