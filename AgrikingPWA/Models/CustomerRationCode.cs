using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class CustomerRationCode
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? ExportCode { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
