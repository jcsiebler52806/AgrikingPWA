using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class TransferOrder
{
    public int Id { get; set; }

    public int NetSuiteId { get; set; }

    public string? OrderNumber { get; set; }

    public string? SubsidiaryId { get; set; }

    public DateTime? TransferDateTime { get; set; }

    public DateTime? TruckShipDateTime { get; set; }

    public string? TruckId { get; set; }

    public string? TruckDropId { get; set; }

    public int? FromBinId { get; set; }

    public int? FromLocationId { get; set; }

    public int? ToBinId { get; set; }

    public int? ToLocationId { get; set; }

    public string? ShipToAddress { get; set; }

    public string? ShipToAddress2 { get; set; }

    public string? ShipToAddressee { get; set; }

    public string? ShipToCity { get; set; }

    public string? ShipToStateId { get; set; }

    public string? ShipToZip { get; set; }

    public string? TransferStatus { get; set; }

    public string? SalespersonId { get; set; }

    public string? Memo { get; set; }

    public int? NstruckDropId { get; set; }

    public int? NstruckId { get; set; }

    public DateTime? RequestedShipDateTime { get; set; }

    public virtual Bin? FromBin { get; set; }

    public virtual Location? FromLocation { get; set; }

    public virtual Nstruck? Nstruck { get; set; }

    public virtual NstruckDrop? NstruckDrop { get; set; }

    public virtual Salesperson? Salesperson { get; set; }

    public virtual State? ShipToState { get; set; }

    public virtual Subsidiary? Subsidiary { get; set; }

    public virtual Bin? ToBin { get; set; }

    public virtual Location? ToLocation { get; set; }

    public virtual ICollection<TransferOrdersDetail> TransferOrdersDetails { get; set; } = new List<TransferOrdersDetail>();

    public virtual Truck? Truck { get; set; }

    public virtual TruckDrop? TruckDrop { get; set; }
}
