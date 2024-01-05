using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ExportCreditMemo
{
    public int Id { get; set; }

    public string? RecordType { get; set; }

    public string? CreditMemoId { get; set; }

    public string? CustomerId { get; set; }

    public string? SalespersonId { get; set; }

    public string? InvoiceType { get; set; }

    public string? InvoiceDate { get; set; }

    public string? TermsId { get; set; }

    public string? DealerDiscountPercent { get; set; }

    public string? DealerDiscountAmount { get; set; }

    public string? ServiceCenterId { get; set; }

    public string? RationId { get; set; }

    public string? CurrencyId { get; set; }

    public string? EuroRate { get; set; }

    public string? Gbprate { get; set; }

    public string? Zone { get; set; }
}
