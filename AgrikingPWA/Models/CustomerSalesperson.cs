using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class CustomerSalesperson
{
    public string CustomerId { get; set; } = null!;

    public string SalespersonId { get; set; } = null!;

    public decimal SalesPercent { get; set; }

    public decimal CommissionPercent { get; set; }

    public string? NetSuiteId { get; set; }

    public int Id { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Salesperson Salesperson { get; set; } = null!;
}
