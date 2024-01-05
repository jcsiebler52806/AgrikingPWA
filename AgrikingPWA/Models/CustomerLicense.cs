using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class CustomerLicense
{
    public int Id { get; set; }

    public string? CustomerId { get; set; }

    public int LicenseTypeId { get; set; }

    public DateTime ExpirationDate { get; set; }

    public DateTime IssueDate { get; set; }

    public string? LicenseNumber { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual CustomerLicenseType LicenseType { get; set; } = null!;
}
