using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Location
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? Name { get; set; }

    public string? SubsidiaryId { get; set; }

    public string? TruckDropId { get; set; }

    public string? TruckId { get; set; }

    public int Order { get; set; }

    public int? NstruckDropId { get; set; }

    public int? NstruckId { get; set; }

    public virtual ICollection<Bin> Bins { get; set; } = new List<Bin>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual Nstruck? Nstruck { get; set; }

    public virtual NstruckDrop? NstruckDrop { get; set; }

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public virtual Subsidiary? Subsidiary { get; set; }

    public virtual ICollection<TransferOrder> TransferOrderFromLocations { get; set; } = new List<TransferOrder>();

    public virtual ICollection<TransferOrder> TransferOrderToLocations { get; set; } = new List<TransferOrder>();

    public virtual Truck? Truck { get; set; }

    public virtual TruckDrop? TruckDrop { get; set; }

    public virtual ICollection<WorkOrderBatchAssembly> WorkOrderBatchAssemblies { get; set; } = new List<WorkOrderBatchAssembly>();

    public virtual ICollection<WorkOrderBatch> WorkOrderBatches { get; set; } = new List<WorkOrderBatch>();

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
