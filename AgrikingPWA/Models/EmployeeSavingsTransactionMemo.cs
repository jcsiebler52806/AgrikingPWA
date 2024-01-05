using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmployeeSavingsTransactionMemo
{
    public Guid Id { get; set; }

    public Guid TransactionId { get; set; }

    public string? Memo { get; set; }

    public virtual EmployeeSavingsTransaction Transaction { get; set; } = null!;
}
