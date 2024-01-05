using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class CustomerLicenseType
{
    public int Id { get; set; }

    public string? Abbreviation { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CustomerLicense> CustomerLicenses { get; set; } = new List<CustomerLicense>();
}
