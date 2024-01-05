using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SubsidiaryItem
{
    public int Id { get; set; }

    public string? SubsidiaryId { get; set; }

    public string? ItemId { get; set; }

    public virtual Item? Item { get; set; }

    public virtual Subsidiary? Subsidiary { get; set; }
}
