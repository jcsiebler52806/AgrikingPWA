using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class TruckDefault
{
    public int Id { get; set; }

    public string? TruckId { get; set; }

    public int CycleDays { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? NstruckId { get; set; }

    public virtual Nstruck? Nstruck { get; set; }

    public virtual Truck? Truck { get; set; }
}
