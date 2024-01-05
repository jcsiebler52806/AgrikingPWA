using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class NamePrefix
{
    public string Id { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Order { get; set; }

    public bool Default { get; set; }

    public bool Active { get; set; }
}
