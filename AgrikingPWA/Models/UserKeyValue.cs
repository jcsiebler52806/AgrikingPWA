using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class UserKeyValue
{
    public string UserId { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string? Value { get; set; }

    public virtual User User { get; set; } = null!;
}
