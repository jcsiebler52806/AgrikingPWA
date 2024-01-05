using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Salesperson
{
    public string Id { get; set; } = null!;

    public string? DisplayName { get; set; }

    public string? RegionId { get; set; }

    public string? DivisionId { get; set; }

    public bool Inactive { get; set; }

    public string? PriceLevelId { get; set; }

    public string? TruckDropId { get; set; }

    public string? TruckId { get; set; }

    public string? NetSuiteId { get; set; }

    public string? SubsidiaryId { get; set; }

    public string? EmployeeId { get; set; }

    public string? ServiceCenterId { get; set; }

    public int? LocationId { get; set; }

    public string? CurrencyId { get; set; }

    public int? NstruckDropId { get; set; }

    public int? NstruckId { get; set; }

    public virtual ICollection<Bin> Bins { get; set; } = new List<Bin>();

    public virtual ICollection<CommissionDetail> CommissionDetails { get; set; } = new List<CommissionDetail>();

    public virtual ICollection<CommissionPayment> CommissionPayments { get; set; } = new List<CommissionPayment>();

    public virtual ICollection<Commission> Commissions { get; set; } = new List<Commission>();

    public virtual Currency? Currency { get; set; }

    public virtual ICollection<CustomerSalesperson> CustomerSalespeople { get; set; } = new List<CustomerSalesperson>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual Division? Division { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<ItemFulfillmentDetail> ItemFulfillmentDetails { get; set; } = new List<ItemFulfillmentDetail>();

    public virtual ICollection<ItemFulfillment> ItemFulfillments { get; set; } = new List<ItemFulfillment>();

    public virtual Nstruck? Nstruck { get; set; }

    public virtual NstruckDrop? NstruckDrop { get; set; }

    public virtual PriceLevel? PriceLevel { get; set; }

    public virtual Region? Region { get; set; }

    public virtual ICollection<SalesOrderCommissionDetail> SalesOrderCommissionDetails { get; set; } = new List<SalesOrderCommissionDetail>();

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public virtual ICollection<SalespersonExpenseAccount> SalespersonExpenseAccounts { get; set; } = new List<SalespersonExpenseAccount>();

    public virtual ICollection<SampleNotification> SampleNotifications { get; set; } = new List<SampleNotification>();

    public virtual ICollection<SampleRequest> SampleRequests { get; set; } = new List<SampleRequest>();

    public virtual ServiceCenter? ServiceCenter { get; set; }

    public virtual Subsidiary? Subsidiary { get; set; }

    public virtual ICollection<TransferOrder> TransferOrders { get; set; } = new List<TransferOrder>();

    public virtual Truck? Truck { get; set; }

    public virtual TruckDrop? TruckDrop { get; set; }
}
