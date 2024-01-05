using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ExportMillAllocationCommission
{
    public int Id { get; set; }

    public string? RecordType { get; set; }

    public string? InvoiceId { get; set; }

    public string? Split1Id { get; set; }

    public decimal Split1PresidentsClubRate { get; set; }

    public decimal Split1CommissionRate { get; set; }

    public string? Split2Id { get; set; }

    public decimal Split2PresidentsClubRate { get; set; }

    public decimal Split2CommissionRate { get; set; }

    public string? Split3Id { get; set; }

    public decimal Split3PresidentsClubRate { get; set; }

    public decimal Split3CommissionRate { get; set; }

    public string? Split4Id { get; set; }

    public decimal Split4PresidentsClubRate { get; set; }

    public decimal Split4CommissionRate { get; set; }
}
