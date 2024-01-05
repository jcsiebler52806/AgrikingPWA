using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SmartCheckEmployee
{
    public int Id { get; set; }

    public int SmartCheckId { get; set; }

    public string? EmployeeId { get; set; }

    public bool Primary { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual SmartCheck SmartCheck { get; set; } = null!;
}
