using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SalespersonExpenseTransaction
{
    public Guid Id { get; set; }

    public Guid AccountId { get; set; }

    public string? TypeId { get; set; }

    public DateTime TransactionDateTime { get; set; }

    public virtual SalespersonExpenseAccount Account { get; set; } = null!;

    public virtual SalespersonExpenseTransactionType? Type { get; set; }
}
