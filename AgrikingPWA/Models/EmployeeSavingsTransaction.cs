using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmployeeSavingsTransaction
{
    public Guid Id { get; set; }

    public Guid AccountId { get; set; }

    public string? TypeId { get; set; }

    public DateTime TransactionDateTime { get; set; }

    public decimal Amount { get; set; }

    public decimal Balance { get; set; }

    public virtual EmployeeSavingsAccount Account { get; set; } = null!;

    public virtual ICollection<EmployeeSavingsTransactionMemo> EmployeeSavingsTransactionMemos { get; set; } = new List<EmployeeSavingsTransactionMemo>();

    public virtual EmployeeSavingsTransactionType? Type { get; set; }
}
