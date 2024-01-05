﻿using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class PaymentTerm
{
    public string Id { get; set; } = null!;

    public string? NetSuiteId { get; set; }

    public string? DisplayName { get; set; }

    public bool Inactive { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
