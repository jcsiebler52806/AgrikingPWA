using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ExportInvoiceDetail
{
    public string? RecordType { get; set; }

    public string? InvoiceId { get; set; }

    public string? LineNumber { get; set; }

    public string? ItemId { get; set; }

    public string? ProductGroupId { get; set; }

    public string? Units { get; set; }

    public string? UnitWeight { get; set; }

    public string? UnitPrice { get; set; }

    public string? Price { get; set; }

    public string? PresidentsClubAmount { get; set; }

    public int Id { get; set; }
}
