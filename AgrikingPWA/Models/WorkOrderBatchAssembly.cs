using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class WorkOrderBatchAssembly
{
    public int Id { get; set; }

    public int WorkOrderBatchId { get; set; }

    public string? SubsidiaryId { get; set; }

    public int? LocationId { get; set; }

    public string? ItemId { get; set; }

    public string? ItemFormulaId { get; set; }

    public string? ItemFormulaRevisionId { get; set; }

    public double Quantity { get; set; }

    public int? UnitId { get; set; }

    public string? UnitTypeId { get; set; }

    public DateTime? CompletedDateTime { get; set; }

    public DateTime? PostedDateTime { get; set; }

    public string? Lot { get; set; }

    public int? NetSuiteId { get; set; }

    public string? Transaction { get; set; }

    public double BaseQuantity { get; set; }

    public virtual Item? Item { get; set; }

    public virtual ItemFormula? ItemFormula { get; set; }

    public virtual ItemFormulaRevision? ItemFormulaRevision { get; set; }

    public virtual Location? Location { get; set; }

    public virtual Subsidiary? Subsidiary { get; set; }

    public virtual Unit? Unit { get; set; }

    public virtual UnitType? UnitType { get; set; }

    public virtual WorkOrderBatch WorkOrderBatch { get; set; } = null!;

    public virtual ICollection<WorkOrderBatchAssemblyComponent> WorkOrderBatchAssemblyComponents { get; set; } = new List<WorkOrderBatchAssemblyComponent>();
}
