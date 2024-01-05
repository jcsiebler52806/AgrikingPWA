using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ItemFormulaRevisionComponent
{
    public string Id { get; set; } = null!;

    public string? ItemFormulaRevisionId { get; set; }

    public decimal ComponentYield { get; set; }

    public decimal Bomquantity { get; set; }

    public string? ItemId { get; set; }

    public int? InstructionCode { get; set; }

    public int SequenceId { get; set; }

    public int? MixSpeed { get; set; }

    public int? MixTime { get; set; }

    public decimal Quantity { get; set; }

    public virtual ItemFormulaRevision? ItemFormulaRevision { get; set; }
}
