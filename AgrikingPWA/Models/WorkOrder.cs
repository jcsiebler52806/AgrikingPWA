using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class WorkOrder
{
    public string Id { get; set; } = null!;

    public DateTime? CompletedDateTime { get; set; }

    public string? ItemFormulaId { get; set; }

    public string? ItemFormulaRevisionId { get; set; }

    public string? ItemId { get; set; }

    public int? LocationId { get; set; }

    public int? NetSuiteId { get; set; }

    public DateTime? PostedDateTime { get; set; }

    public double Quantity { get; set; }

    public DateTime? ScheduledDateTime { get; set; }

    public DateTime? StartedDateTime { get; set; }

    public string? SubsidiaryId { get; set; }

    public int? UnitId { get; set; }

    public string? UnitTypeId { get; set; }

    public int? SterlingRunKey { get; set; }

    public string? Status { get; set; }

    public virtual Item? Item { get; set; }

    public virtual ItemFormula? ItemFormula { get; set; }

    public virtual ItemFormulaRevision? ItemFormulaRevision { get; set; }

    public virtual Location? Location { get; set; }

    public virtual Subsidiary? Subsidiary { get; set; }

    public virtual Unit? Unit { get; set; }

    public virtual UnitType? UnitType { get; set; }

    public virtual ICollection<WorkOrderBatch> WorkOrderBatches { get; set; } = new List<WorkOrderBatch>();
}
