using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SalespersonExpenseAccount
{
    public Guid Id { get; set; }

    public string? SalespersonId { get; set; }

    public virtual Salesperson? Salesperson { get; set; }

    public virtual ICollection<SalespersonExpenseTransaction> SalespersonExpenseTransactions { get; set; } = new List<SalespersonExpenseTransaction>();
}
