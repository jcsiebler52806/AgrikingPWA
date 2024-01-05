using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class DepartmentManager
{
    public string? DepartmentId { get; set; }

    public string? EmployeeNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int Id { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Employee? EmployeeNumberNavigation { get; set; }
}
