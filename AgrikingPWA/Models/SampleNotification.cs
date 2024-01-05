using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SampleNotification
{
    public int Id { get; set; }

    public string? SalespersonId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? CustomerId { get; set; }

    public bool? SendToAreaManager { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Salesperson? Salesperson { get; set; }
}
