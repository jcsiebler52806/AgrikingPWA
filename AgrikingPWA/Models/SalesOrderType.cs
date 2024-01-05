using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class SalesOrderType
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<CreditMemo> CreditMemos { get; set; } = new List<CreditMemo>();

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();
}
