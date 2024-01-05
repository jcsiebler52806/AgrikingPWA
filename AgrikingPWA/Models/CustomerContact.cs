using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class CustomerContact
{
    public int Id { get; set; }

    public string? NetSuiteId { get; set; }

    public string? CustomerId { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? JobTitle { get; set; }

    public string? Email { get; set; }

    public string? Email2 { get; set; }

    public string? OfficePhone { get; set; }

    public string? MobilePhone { get; set; }

    public string? HomePhone { get; set; }

    public string? Fax { get; set; }

    public bool Inactive { get; set; }

    public bool IsPrimary { get; set; }

    public bool DefaultBilling { get; set; }

    public bool DefaultNutrition { get; set; }

    public bool DefaultShipping { get; set; }

    public virtual Customer? Customer { get; set; }
}
