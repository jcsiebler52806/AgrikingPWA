using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Commission
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? SalespersonId { get; set; }

    public string? InvoiceId { get; set; }

    public decimal SplitCommissionRate { get; set; }

    public decimal PresidentsClubRate { get; set; }

    public virtual Invoice? Invoice { get; set; }

    public virtual Salesperson? Salesperson { get; set; }
}
