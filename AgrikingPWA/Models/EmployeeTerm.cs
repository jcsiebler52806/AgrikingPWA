using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmployeeTerm
{
    public int Id { get; set; }

    public string? EmployeeId { get; set; }

    public string? EmployeeTermTypeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? EmployeeTermEndTypeId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual EmployeeTermEndType? EmployeeTermEndType { get; set; }

    public virtual EmployeeTermType? EmployeeTermType { get; set; }
}
