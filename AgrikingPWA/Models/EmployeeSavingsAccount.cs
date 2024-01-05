using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmployeeSavingsAccount
{
    public Guid Id { get; set; }

    public string? EmployeeId { get; set; }

    public decimal Balance { get; set; }

    public string? StatusId { get; set; }

    public decimal Deduction { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<EmployeeSavingsTransaction> EmployeeSavingsTransactions { get; set; } = new List<EmployeeSavingsTransaction>();

    public virtual EmployeeSavingsAccountStatus? Status { get; set; }
}
