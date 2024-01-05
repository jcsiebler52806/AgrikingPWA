using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class CommissionPayment
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? SalespersonId { get; set; }

    public string? InvoiceId { get; set; }

    public int? InvoiceItemId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public decimal PaymentAmount { get; set; }

    public decimal PaidCommissionAmount { get; set; }

    public decimal PaidSplitCommissionAmount { get; set; }

    public string? CurrencyId { get; set; }

    public string? ItemId { get; set; }

    public virtual Invoice? Invoice { get; set; }

    public virtual InvoiceDetail? InvoiceItem { get; set; }

    public virtual Salesperson? Salesperson { get; set; }
}
