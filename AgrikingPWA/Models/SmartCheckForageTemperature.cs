using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SmartCheckForageTemperature
{
    public int Id { get; set; }

    public int SmartCheckForageId { get; set; }

    public string? Temperature { get; set; }

    public string? Day { get; set; }

    public virtual SmartCheckForage SmartCheckForage { get; set; } = null!;
}
