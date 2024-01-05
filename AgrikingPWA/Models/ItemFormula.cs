using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ItemFormula
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Memo { get; set; }

    public bool UseComponentYield { get; set; }

    public bool Inactive { get; set; }

    public string? NetSuiteId { get; set; }

    public virtual ICollection<ItemFormulaRevision> ItemFormulaRevisions { get; set; } = new List<ItemFormulaRevision>();

    public virtual ICollection<WorkOrderBatchAssembly> WorkOrderBatchAssemblies { get; set; } = new List<WorkOrderBatchAssembly>();

    public virtual ICollection<WorkOrderBatch> WorkOrderBatches { get; set; } = new List<WorkOrderBatch>();

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
