using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class PaymentInvoice
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public int PaymentId { get; set; }

    public string? Type { get; set; }

    public string? InvoiceId { get; set; }

    public decimal PaymentAmount { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal RemainingBalance { get; set; }

    public virtual Invoice? Invoice { get; set; }

    public virtual Payment Payment { get; set; } = null!;
}
