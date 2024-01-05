using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ScheduledTaskJobParameter
{
    public int Id { get; set; }

    public int? ScheduledTaskJobId { get; set; }

    public string? ParameterName { get; set; }

    public string? ParameterValue { get; set; }

    public virtual ScheduledTaskJob? ScheduledTaskJob { get; set; }
}
