using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmployeeTimeEntry
{
    public DateTime TimeEntryDate { get; set; }

    public decimal TimeWorked { get; set; }

    public int Id { get; set; }

    public string? EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }
}
