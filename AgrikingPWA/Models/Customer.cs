using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Customer
{
    public string Id { get; set; } = null!;

    public string? Title { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? CompanyName { get; set; }

    public string? DivisionId { get; set; }

    public string? RegionId { get; set; }

    public string? SalespersonId { get; set; }

    public bool Inactive { get; set; }

    public bool Locked { get; set; }

    public bool Collections { get; set; }

    public string? Image { get; set; }

    public string? WebAddress { get; set; }

    public string? CurrencyId { get; set; }

    public string? PaymentTermId { get; set; }

    public string? PriceLevelId { get; set; }

    public string? DisplayName { get; set; }

    public string? TruckDropId { get; set; }

    public string? SubsidiaryId { get; set; }

    public string? TruckId { get; set; }

    public string? NetSuiteId { get; set; }

    public string? FirstName { get; set; }

    public bool Individual { get; set; }

    public decimal Balance { get; set; }

    public decimal Current { get; set; }

    public int DaysOverdue { get; set; }

    public decimal Deposit { get; set; }

    public decimal NinetyDay { get; set; }

    public decimal OverNinety { get; set; }

    public decimal Overdue { get; set; }

    public decimal SixtyDay { get; set; }

    public decimal ThirtyDay { get; set; }

    public decimal Unbilled { get; set; }

    public string? LandlordCustomerId { get; set; }

    public string? LandlordId { get; set; }

    public decimal TenantRate { get; set; }

    public string? CategoryId { get; set; }

    public int? LocationId { get; set; }

    public bool DealerDiscount { get; set; }

    public bool InactiveClient { get; set; }

    public bool ServiceCharge { get; set; }

    public bool? LabQc { get; set; }

    public bool AccountingApproved { get; set; }

    public bool NetsuiteFlag { get; set; }

    public string? LabCode { get; set; }

    public string? RationCode { get; set; }

    public bool? AdvantageFlag { get; set; }

    public int? CustomerLabCodeId { get; set; }

    public int? CustomerRationCodeId { get; set; }

    public int? CustomerResultDeliveryCodeId { get; set; }

    public bool? RationAnalysisDisplayFlag { get; set; }

    public int? AnimalCount { get; set; }

    public int? NstruckDropId { get; set; }

    public int? NstruckId { get; set; }

    public bool? AllocationAccountFlag { get; set; }

    public bool? UsageAccountFlag { get; set; }

    public bool? RoboticFlag { get; set; }

    public virtual CustomerCategory? Category { get; set; }

    public virtual ICollection<CreditMemo> CreditMemos { get; set; } = new List<CreditMemo>();

    public virtual Currency? Currency { get; set; }

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();

    public virtual ICollection<CustomerContact> CustomerContacts { get; set; } = new List<CustomerContact>();

    public virtual CustomerLabCode? CustomerLabCode { get; set; }

    public virtual ICollection<CustomerLicense> CustomerLicenses { get; set; } = new List<CustomerLicense>();

    public virtual CustomerRationCode? CustomerRationCode { get; set; }

    public virtual CustomerResultDeliveryCode? CustomerResultDeliveryCode { get; set; }

    public virtual ICollection<CustomerSalesperson> CustomerSalespeople { get; set; } = new List<CustomerSalesperson>();

    public virtual ICollection<CustomerServiceCenter> CustomerServiceCenters { get; set; } = new List<CustomerServiceCenter>();

    public virtual ICollection<DistributionTemp> DistributionTemps { get; set; } = new List<DistributionTemp>();

    public virtual ICollection<Distribution> Distributions { get; set; } = new List<Distribution>();

    public virtual Division? Division { get; set; }

    public virtual ICollection<Customer> InverseLandlord { get; set; } = new List<Customer>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual Customer? Landlord { get; set; }

    public virtual Location? Location { get; set; }

    public virtual ICollection<MillAllocationDetail> MillAllocationDetails { get; set; } = new List<MillAllocationDetail>();

    public virtual ICollection<MillAllocation> MillAllocations { get; set; } = new List<MillAllocation>();

    public virtual Nstruck? Nstruck { get; set; }

    public virtual NstruckDrop? NstruckDrop { get; set; }

    public virtual PaymentTerm? PaymentTerm { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual PriceLevel? PriceLevel { get; set; }

    public virtual Region? Region { get; set; }

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public virtual Salesperson? Salesperson { get; set; }

    public virtual ICollection<SampleNotification> SampleNotifications { get; set; } = new List<SampleNotification>();

    public virtual ICollection<Sample> Samples { get; set; } = new List<Sample>();

    public virtual ICollection<SmartCheck> SmartChecks { get; set; } = new List<SmartCheck>();

    public virtual Subsidiary? Subsidiary { get; set; }

    public virtual Truck? Truck { get; set; }

    public virtual TruckDrop? TruckDrop { get; set; }
}
