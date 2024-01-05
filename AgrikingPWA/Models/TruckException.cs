using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class TruckException
{
    public int Id { get; set; }

    public string? TruckId { get; set; }

    public DateTime? OriginalDate { get; set; }

    public DateTime? ExceptionDate { get; set; }

    public int? NstruckId { get; set; }

    public virtual Nstruck? Nstruck { get; set; }

    public virtual Truck? Truck { get; set; }
}
