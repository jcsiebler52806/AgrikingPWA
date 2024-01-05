using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmployeeContact
{
    public int Id { get; set; }

    public string? EmployeeId { get; set; }

    public string? Category { get; set; }

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

    public virtual Employee? Employee { get; set; }
}
