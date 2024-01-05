using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class WorkOrderBatchComponent
{
    public int Id { get; set; }

    public int WorkOrderBatchId { get; set; }

    public string? ItemId { get; set; }

    public string? BinName { get; set; }

    public string? Lot { get; set; }

    public double Quantity { get; set; }

    public double Target { get; set; }

    public int? BinId { get; set; }

    public int? SequenceId { get; set; }

    public int LineNumber { get; set; }

    public int? SterlingBinId { get; set; }

    public virtual Bin? Bin { get; set; }

    public virtual Item? Item { get; set; }

    public virtual WorkOrderBatch WorkOrderBatch { get; set; } = null!;
}
