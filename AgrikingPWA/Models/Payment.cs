using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Payment
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? CustomerId { get; set; }

    public string? TransactionId { get; set; }

    public string? CurrencyId { get; set; }

    public string? SubsidiaryId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public decimal PaymentAmount { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<PaymentInvoice> PaymentInvoices { get; set; } = new List<PaymentInvoice>();

    public virtual Subsidiary? Subsidiary { get; set; }
}
