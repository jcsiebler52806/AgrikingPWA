using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class CommissionDetail
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? SalespersonId { get; set; }

    public string? InvoiceId { get; set; }

    public decimal CommissionAmount { get; set; }

    public decimal PresidentsClubSplitPercent { get; set; }

    public decimal PresidentsClubAmount { get; set; }

    public decimal CommissionSplitAmount { get; set; }

    public decimal CommissionSplitPercent { get; set; }

    public string? CurrencyId { get; set; }

    public string? ItemId { get; set; }

    public decimal PresidentsClubDollarAmount { get; set; }

    public decimal PresidentsClubSplitAmount { get; set; }

    public decimal PresidentsClubSplitDollarAmount { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual Invoice? Invoice { get; set; }

    public virtual Item? Item { get; set; }

    public virtual Salesperson? Salesperson { get; set; }
}
