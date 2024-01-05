using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SystemKeyValue
{
    public string Id { get; set; } = null!;

    public string? Key { get; set; }

    public string? Value { get; set; }
}
