using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class WorkOrderBatchAssemblyComponent
{
    public int Id { get; set; }

    public int WorkOrderBatchAssemblyId { get; set; }

    public int LineNumber { get; set; }

    public string? ItemId { get; set; }

    public int? BinId { get; set; }

    public string? Lot { get; set; }

    public double Quantity { get; set; }

    public virtual Bin? Bin { get; set; }

    public virtual Item? Item { get; set; }

    public virtual WorkOrderBatchAssembly WorkOrderBatchAssembly { get; set; } = null!;
}
