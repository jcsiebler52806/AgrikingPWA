using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Bin
{
    public int Id { get; set; }

    public int? NetSuiteId { get; set; }

    public string? SterlingId { get; set; }

    public string? Name { get; set; }

    public int LocationId { get; set; }

    public string? SalespersonId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual Salesperson? Salesperson { get; set; }

    public virtual ICollection<TransferOrder> TransferOrderFromBins { get; set; } = new List<TransferOrder>();

    public virtual ICollection<TransferOrder> TransferOrderToBins { get; set; } = new List<TransferOrder>();

    public virtual ICollection<WorkOrderBatchAssemblyComponent> WorkOrderBatchAssemblyComponents { get; set; } = new List<WorkOrderBatchAssemblyComponent>();

    public virtual ICollection<WorkOrderBatchComponent> WorkOrderBatchComponents { get; set; } = new List<WorkOrderBatchComponent>();
}
