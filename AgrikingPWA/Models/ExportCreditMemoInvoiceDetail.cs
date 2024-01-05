using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ExportCreditMemoInvoiceDetail
{
    public int Id { get; set; }

    public string? RecordType { get; set; }

    public string? PaymentId { get; set; }

    public string? Type { get; set; }

    public string? InvoiceId { get; set; }

    public string? PaymentAmount { get; set; }

    public string? DiscountAmount { get; set; }

    public string? TotalAmount { get; set; }

    public string? RemainingBalance { get; set; }

    public string? CustomerId { get; set; }
}
