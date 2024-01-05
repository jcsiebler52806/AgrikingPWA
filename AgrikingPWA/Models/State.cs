using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class State
{
    public string Id { get; set; } = null!;

    public string? CountryId { get; set; }

    public string? Name { get; set; }

    public virtual Country? Country { get; set; }

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();

    public virtual ICollection<EmployeeAddress> EmployeeAddresses { get; set; } = new List<EmployeeAddress>();

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public virtual ICollection<SampleAnalysisStatistic> SampleAnalysisStatistics { get; set; } = new List<SampleAnalysisStatistic>();

    public virtual ICollection<ServiceCenter> ServiceCenters { get; set; } = new List<ServiceCenter>();

    public virtual ICollection<TransferOrder> TransferOrders { get; set; } = new List<TransferOrder>();

    public virtual ICollection<ZipCode> ZipCodes { get; set; } = new List<ZipCode>();
}
