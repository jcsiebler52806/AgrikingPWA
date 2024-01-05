using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ItemVolumePrice
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? ItemId { get; set; }

    public int? ItemPricePeriodId { get; set; }

    public decimal MinimumQuantity { get; set; }

    public decimal MaximumQuantity { get; set; }

    public bool Approval { get; set; }

    public decimal Price { get; set; }

    public virtual Item? Item { get; set; }

    public virtual ItemPricePeriod? ItemPricePeriod { get; set; }
}
