using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class UnitType
{
    public string Id { get; set; } = null!;

    public string? NetSuiteId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ItemFulfillmentDetail> ItemFulfillmentDetails { get; set; } = new List<ItemFulfillmentDetail>();

    public virtual ICollection<MillAllocationDetailItem> MillAllocationDetailItems { get; set; } = new List<MillAllocationDetailItem>();

    public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; } = new List<SalesOrderDetail>();

    public virtual ICollection<TransferOrdersDetail> TransferOrdersDetails { get; set; } = new List<TransferOrdersDetail>();

    public virtual ICollection<Unit> Units { get; set; } = new List<Unit>();

    public virtual ICollection<WorkOrderBatchAssembly> WorkOrderBatchAssemblies { get; set; } = new List<WorkOrderBatchAssembly>();

    public virtual ICollection<WorkOrderBatch> WorkOrderBatches { get; set; } = new List<WorkOrderBatch>();

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
