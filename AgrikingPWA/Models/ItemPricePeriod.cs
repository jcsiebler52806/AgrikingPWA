using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ItemPricePeriod
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? Description { get; set; }

    public bool Inactive { get; set; }

    public DateTime EndDate { get; set; }

    public string? ItemId { get; set; }

    public DateTime StartDate { get; set; }

    public string? PriceLevelId { get; set; }

    public bool BookingFlag { get; set; }

    public virtual Item? Item { get; set; }

    public virtual ICollection<ItemVolumePrice> ItemVolumePrices { get; set; } = new List<ItemVolumePrice>();

    public virtual PriceLevel? PriceLevel { get; set; }
}
