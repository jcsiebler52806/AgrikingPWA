using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class CreditMemo
{
    public string Id { get; set; } = null!;

    public string? NetSuiteId { get; set; }

    public string? CustomerId { get; set; }

    public string? CurrencyId { get; set; }

    public DateTime? CreditDate { get; set; }

    public string? HistoricalInvoiceId { get; set; }

    public string? SalesOrderTypeId { get; set; }

    public virtual ICollection<CreditMemoDetail> CreditMemoDetails { get; set; } = new List<CreditMemoDetail>();

    public virtual ICollection<CreditMemoInvoice> CreditMemoInvoices { get; set; } = new List<CreditMemoInvoice>();

    public virtual Currency? Currency { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual SalesOrderType? SalesOrderType { get; set; }
}
