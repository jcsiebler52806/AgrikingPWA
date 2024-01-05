using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ItemPrice
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? ItemId { get; set; }

    public string? PriceLevelId { get; set; }

    public decimal Price { get; set; }

    public string? CurrencyId { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual Item? Item { get; set; }

    public virtual PriceLevel? PriceLevel { get; set; }
}
