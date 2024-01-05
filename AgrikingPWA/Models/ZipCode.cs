using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ZipCode
{
    public string Id { get; set; } = null!;

    public string? City { get; set; }

    public string? StateId { get; set; }

    public string? County { get; set; }

    public virtual State? State { get; set; }
}
