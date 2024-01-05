using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class CreditMemoInvoice
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? CreditMemoId { get; set; }

    public string? InvoiceId { get; set; }

    public decimal PaymentAmount { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal RemainingBalance { get; set; }

    public virtual CreditMemo? CreditMemo { get; set; }

    public virtual Invoice? Invoice { get; set; }
}
