using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ExportCustomer
{
    public string? ClientId { get; set; }

    public string? DisplayName { get; set; }

    public string? SubsidiaryId { get; set; }

    public string? DivisionId { get; set; }

    public string? RegionId { get; set; }

    public string? SalespersonId { get; set; }

    public string? PaymentTermId { get; set; }

    public string? PriceLevelId { get; set; }

    public string? TruckId { get; set; }

    public string? TruckDropId { get; set; }

    public string? Category { get; set; }

    public string? CategoryId { get; set; }

    public bool Inactive { get; set; }

    public bool Locked { get; set; }

    public bool Collections { get; set; }

    public decimal Balance { get; set; }

    public decimal Overdue { get; set; }

    public int DaysOverdue { get; set; }

    public decimal Deposit { get; set; }

    public decimal Unbilled { get; set; }

    public decimal Current { get; set; }

    public decimal ThirtyDay { get; set; }

    public decimal SixtyDay { get; set; }

    public decimal NinetyDay { get; set; }

    public decimal OverNinety { get; set; }

    public string? LandlordCustomerId { get; set; }

    public decimal TenantRate { get; set; }

    public decimal Split1CommissionRate { get; set; }

    public string? Split1Id { get; set; }

    public decimal Split1PresidentsClubRate { get; set; }

    public decimal Split2CommissionRate { get; set; }

    public string? Split2Id { get; set; }

    public decimal Split2PresidentsClubRate { get; set; }

    public decimal Split3CommissionRate { get; set; }

    public string? Split3Id { get; set; }

    public decimal Split3PresidentsClubRate { get; set; }

    public decimal Split4CommissionRate { get; set; }

    public string? Split4Id { get; set; }

    public decimal Split4PresidentsClubRate { get; set; }

    public int Id { get; set; }

    public string? ServiceCenter1Id { get; set; }

    public string? ServiceCenter2Id { get; set; }

    public string? ServiceCenter3Id { get; set; }

    public string? ServiceCenter4Id { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? HomePhone { get; set; }

    public string? MobilePhone { get; set; }

    public string? OfficePhone { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? CompanyName { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? AdvantageFlag { get; set; }

    public string? AnimalCount { get; set; }

    public string? CustomerLabCodeId { get; set; }

    public string? CustomerRationCodeId { get; set; }

    public string? CustomerResultDeliveryCodeId { get; set; }

    public string? RationAnalysisDisplayFlag { get; set; }

    public bool? Robotic { get; set; }
}
