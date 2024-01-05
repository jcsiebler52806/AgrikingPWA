using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Item
{
    public string Id { get; set; } = null!;

    public bool Commissionable { get; set; }

    public string? Name { get; set; }

    public string? UnitTypeId { get; set; }

    public string? Department { get; set; }

    public string? Class { get; set; }

    public string? Location { get; set; }

    public string? CostingMethod { get; set; }

    public string? NetSuiteType { get; set; }

    public string? ProductGroup { get; set; }

    public decimal ItemWeight { get; set; }

    public bool CanBeFulfilled { get; set; }

    public string? ItemCategory { get; set; }

    public string? ProductType { get; set; }

    public bool BookingItem { get; set; }

    public bool Orderable { get; set; }

    public bool AppOrderable { get; set; }

    public decimal DealerDiscountRate { get; set; }

    public decimal PremixCommissionRate { get; set; }

    public bool Inactive { get; set; }

    public string? NetSuiteId { get; set; }

    public string? Image { get; set; }

    public int? BaseUnitId { get; set; }

    public int? PurchaseUnitId { get; set; }

    public int? SaleUnitId { get; set; }

    public int? StockUnitId { get; set; }

    public bool InactiveItem { get; set; }

    public bool? WaterSoluble { get; set; }

    public virtual Unit? BaseUnit { get; set; }

    public virtual ICollection<CommissionDetail> CommissionDetails { get; set; } = new List<CommissionDetail>();

    public virtual ICollection<CreditMemoDetail> CreditMemoDetails { get; set; } = new List<CreditMemoDetail>();

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    public virtual ICollection<ItemFulfillmentDetail> ItemFulfillmentDetails { get; set; } = new List<ItemFulfillmentDetail>();

    public virtual ICollection<ItemPricePeriod> ItemPricePeriods { get; set; } = new List<ItemPricePeriod>();

    public virtual ICollection<ItemPrice> ItemPrices { get; set; } = new List<ItemPrice>();

    public virtual ICollection<ItemVolumePrice> ItemVolumePrices { get; set; } = new List<ItemVolumePrice>();

    public virtual ICollection<MillAllocationDetailItem> MillAllocationDetailItems { get; set; } = new List<MillAllocationDetailItem>();

    public virtual Unit? PurchaseUnit { get; set; }

    public virtual Unit? SaleUnit { get; set; }

    public virtual ICollection<SalesOrderCommissionDetail> SalesOrderCommissionDetails { get; set; } = new List<SalesOrderCommissionDetail>();

    public virtual ICollection<SalesOrderDetailLot> SalesOrderDetailLots { get; set; } = new List<SalesOrderDetailLot>();

    public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; } = new List<SalesOrderDetail>();

    public virtual Unit? StockUnit { get; set; }

    public virtual ICollection<SubsidiaryItem> SubsidiaryItems { get; set; } = new List<SubsidiaryItem>();

    public virtual ICollection<TransferOrdersDetail> TransferOrdersDetails { get; set; } = new List<TransferOrdersDetail>();

    public virtual ICollection<WorkOrderBatchAssembly> WorkOrderBatchAssemblies { get; set; } = new List<WorkOrderBatchAssembly>();

    public virtual ICollection<WorkOrderBatchAssemblyComponent> WorkOrderBatchAssemblyComponents { get; set; } = new List<WorkOrderBatchAssemblyComponent>();

    public virtual ICollection<WorkOrderBatchComponent> WorkOrderBatchComponents { get; set; } = new List<WorkOrderBatchComponent>();

    public virtual ICollection<WorkOrderBatch> WorkOrderBatches { get; set; } = new List<WorkOrderBatch>();

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
