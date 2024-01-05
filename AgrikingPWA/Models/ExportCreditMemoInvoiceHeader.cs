using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ExportCreditMemoInvoiceHeader
{
    public int Id { get; set; }

    public string? RecordType { get; set; }

    public string? PaymentId { get; set; }

    public string? CustomerId { get; set; }

    public string? TransactionId { get; set; }

    public string? CurrencyId { get; set; }

    public string? SubsidiaryId { get; set; }

    public string? PaymentDate { get; set; }

    public string? PaymentAmount { get; set; }
}
