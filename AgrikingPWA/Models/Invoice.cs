using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Invoice
{
    public string Id { get; set; } = null!;

    public string? NetSuiteId { get; set; }

    public string? CustomerId { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? HistoricalInvoiceId { get; set; }

    public string? SalesOrderId { get; set; }

    public string? CurrencyId { get; set; }

    public virtual ICollection<CommissionDetail> CommissionDetails { get; set; } = new List<CommissionDetail>();

    public virtual ICollection<CommissionPayment> CommissionPayments { get; set; } = new List<CommissionPayment>();

    public virtual ICollection<Commission> Commissions { get; set; } = new List<Commission>();

    public virtual ICollection<CreditMemoInvoice> CreditMemoInvoices { get; set; } = new List<CreditMemoInvoice>();

    public virtual Currency? Currency { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    public virtual ICollection<PaymentInvoice> PaymentInvoices { get; set; } = new List<PaymentInvoice>();

    public virtual SalesOrder? SalesOrder { get; set; }
}
