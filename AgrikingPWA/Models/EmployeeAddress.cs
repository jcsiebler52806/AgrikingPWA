using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmployeeAddress
{
    public int Id { get; set; }

    public string? EmployeeId { get; set; }

    public string? Attention { get; set; }

    public string? Addressee { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? StateId { get; set; }

    public string? Zip { get; set; }

    public string? CountryId { get; set; }

    public bool DefaultBilling { get; set; }

    public bool DefaultShipping { get; set; }

    public bool Residential { get; set; }

    public bool Inactive { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public string? NetSuiteId { get; set; }

    public bool DefaultAddress { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual State? State { get; set; }
}
