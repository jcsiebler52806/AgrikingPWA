using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ItemFormulaRevision
{
    public string Id { get; set; } = null!;

    public string? ItemFormulaId { get; set; }

    public string? Name { get; set; }

    public string? Memo { get; set; }

    public DateTime? EffectiveStartDate { get; set; }

    public DateTime? EffectiveEndDate { get; set; }

    public bool Inactive { get; set; }

    public int DefaultBatchSize { get; set; }

    public int MaxBatchSize { get; set; }

    public int MinBatchSize { get; set; }

    public virtual ItemFormula? ItemFormula { get; set; }

    public virtual ICollection<ItemFormulaRevisionComponent> ItemFormulaRevisionComponents { get; set; } = new List<ItemFormulaRevisionComponent>();

    public virtual ICollection<WorkOrderBatchAssembly> WorkOrderBatchAssemblies { get; set; } = new List<WorkOrderBatchAssembly>();

    public virtual ICollection<WorkOrderBatch> WorkOrderBatches { get; set; } = new List<WorkOrderBatch>();

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
