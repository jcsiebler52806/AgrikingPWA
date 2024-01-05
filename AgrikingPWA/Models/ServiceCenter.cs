using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ServiceCenter
{
    public string Id { get; set; } = null!;

    public string? NetSuiteId { get; set; }

    public string? DisplayName { get; set; }

    public bool Inactive { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? CountryId { get; set; }

    public string? StateId { get; set; }

    public string? Zip { get; set; }

    public virtual Country? Country { get; set; }

    public virtual ICollection<CustomerServiceCenter> CustomerServiceCenters { get; set; } = new List<CustomerServiceCenter>();

    public virtual ICollection<Salesperson> Salespeople { get; set; } = new List<Salesperson>();

    public virtual State? State { get; set; }
}
