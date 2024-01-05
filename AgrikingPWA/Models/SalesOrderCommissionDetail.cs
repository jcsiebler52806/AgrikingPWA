using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SalesOrderCommissionDetail
{
    public int Id { get; set; }

    public string? SalesOrderId { get; set; }

    public int LineNumber { get; set; }

    public string? ItemId { get; set; }

    public string? SalespersonId { get; set; }

    public decimal CommissionPercent { get; set; }

    public decimal SalesPercent { get; set; }

    public virtual Item? Item { get; set; }

    public virtual SalesOrder? SalesOrder { get; set; }

    public virtual Salesperson? Salesperson { get; set; }
}
