using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class TruckFinal
{
    public int Id { get; set; }

    public string? TruckId { get; set; }

    public DateTime? TruckShipDateTime { get; set; }

    public DateTime? FinalizedDateTime { get; set; }

    public int? NstruckId { get; set; }

    public virtual Nstruck? Nstruck { get; set; }

    public virtual Truck? Truck { get; set; }
}
