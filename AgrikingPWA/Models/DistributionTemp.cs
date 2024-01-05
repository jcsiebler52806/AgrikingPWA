using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class DistributionTemp
{
    public int Id { get; set; }

    public int ReportId { get; set; }

    public string? CustomerId { get; set; }

    public int DistributionTemplateId { get; set; }

    public string? Email { get; set; }

    public string? ContactType { get; set; }

    public int CustomerContactId { get; set; }

    public int CustomerAddressId { get; set; }

    public int EmployeeContactId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Report Report { get; set; } = null!;
}
