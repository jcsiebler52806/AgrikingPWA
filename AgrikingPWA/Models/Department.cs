using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Department
{
    public string Id { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Inactive { get; set; }

    public virtual ICollection<DepartmentManager> DepartmentManagers { get; set; } = new List<DepartmentManager>();

    public virtual ICollection<EmployeeDepartment> EmployeeDepartments { get; set; } = new List<EmployeeDepartment>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
