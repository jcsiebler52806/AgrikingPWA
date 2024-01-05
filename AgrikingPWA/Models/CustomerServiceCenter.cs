using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class CustomerServiceCenter
{
    public int Id { get; set; }

    public string? CustomerId { get; set; }

    public string? ServiceCenterId { get; set; }

    public string? NetSuiteId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ServiceCenter? ServiceCenter { get; set; }
}
