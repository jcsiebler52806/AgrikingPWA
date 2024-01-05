using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmployeeJobTitle
{
    public string? EmployeeId { get; set; }

    public string? JobTitle { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int Id { get; set; }

    public virtual Employee? Employee { get; set; }
}
