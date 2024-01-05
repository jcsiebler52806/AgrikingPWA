using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SalesOrder
{
    public string? NetSuiteId { get; set; }

    public string? ReceiptNumber { get; set; }

    public string? SubsidiaryId { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerPo { get; set; }

    public string? Memo { get; set; }

    public DateTime? OrderDateTime { get; set; }

    public DateTime? RequestedShipDateTime { get; set; }

    public DateTime? TruckShipDateTime { get; set; }

    public string? SalespersonId { get; set; }

    public string? TruckId { get; set; }

    public string? TruckDropId { get; set; }

    public string? SalesOrderTypeId { get; set; }

    public int LocationId { get; set; }

    public string? CurrencyId { get; set; }

    public string Id { get; set; } = null!;

    public string? ShipToAddress { get; set; }

    public string? ShipToAddress2 { get; set; }

    public string? ShipToAddressee { get; set; }

    public string? ShipToCity { get; set; }

    public string? ShipToStateId { get; set; }

    public string? ShipToZip { get; set; }

    public int? ConsignmentBinId { get; set; }

    public string? OrderStatus { get; set; }

    public string? OrderSource { get; set; }

    public int? NstruckDropId { get; set; }

    public int? NstruckId { get; set; }

    public DateTime? DraftDateTime { get; set; }

    public string? UserId { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<ItemFulfillment> ItemFulfillments { get; set; } = new List<ItemFulfillment>();

    public virtual Location Location { get; set; } = null!;

    public virtual Nstruck? Nstruck { get; set; }

    public virtual NstruckDrop? NstruckDrop { get; set; }

    public virtual ICollection<SalesOrderCommissionDetail> SalesOrderCommissionDetails { get; set; } = new List<SalesOrderCommissionDetail>();

    public virtual ICollection<SalesOrderDetailLot> SalesOrderDetailLots { get; set; } = new List<SalesOrderDetailLot>();

    public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; } = new List<SalesOrderDetail>();

    public virtual SalesOrderType? SalesOrderType { get; set; }

    public virtual Salesperson? Salesperson { get; set; }

    public virtual State? ShipToState { get; set; }

    public virtual Subsidiary? Subsidiary { get; set; }

    public virtual Truck? Truck { get; set; }

    public virtual TruckDrop? TruckDrop { get; set; }

    public virtual User? User { get; set; }
}
