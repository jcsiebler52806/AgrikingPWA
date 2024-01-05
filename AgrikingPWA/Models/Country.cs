using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Country
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Number { get; set; }

    public string? CurrencyCode { get; set; }

    public string? Prefix { get; set; }

    public virtual Currency? CurrencyCodeNavigation { get; set; }

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();

    public virtual ICollection<EmployeeAddress> EmployeeAddresses { get; set; } = new List<EmployeeAddress>();

    public virtual ICollection<SampleAnalysisReportRange> SampleAnalysisReportRanges { get; set; } = new List<SampleAnalysisReportRange>();

    public virtual ICollection<SampleAnalysisStatistic> SampleAnalysisStatistics { get; set; } = new List<SampleAnalysisStatistic>();

    public virtual ICollection<SampleAnalysisTargetValue> SampleAnalysisTargetValues { get; set; } = new List<SampleAnalysisTargetValue>();

    public virtual ICollection<ServiceCenter> ServiceCenters { get; set; } = new List<ServiceCenter>();

    public virtual ICollection<State> States { get; set; } = new List<State>();
}
