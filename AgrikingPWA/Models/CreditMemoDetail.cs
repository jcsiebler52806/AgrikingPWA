using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class CreditMemoDetail
{
    public int Id { get; set; }

    public string? CreditMemoId { get; set; }

    public int LineNumber { get; set; }

    public string? ItemId { get; set; }

    public int? UnitId { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal ItemPrice { get; set; }

    public decimal ItemDollarPrice { get; set; }

    public decimal GrossAmount { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal TaxRate { get; set; }

    public virtual CreditMemo? CreditMemo { get; set; }

    public virtual Item? Item { get; set; }

    public virtual Unit? Unit { get; set; }
}
