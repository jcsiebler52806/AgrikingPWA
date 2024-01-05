using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmployeeTermType
{
    public string Id { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Default { get; set; }

    public int Order { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<EmployeeTerm> EmployeeTerms { get; set; } = new List<EmployeeTerm>();
}
