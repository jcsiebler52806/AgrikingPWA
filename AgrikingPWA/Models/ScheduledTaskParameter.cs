using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ScheduledTaskParameter
{
    public int Id { get; set; }

    public int? ScheduledTaskId { get; set; }

    public string? ParameterName { get; set; }

    public string? ParameterValue { get; set; }

    public virtual ScheduledTask? ScheduledTask { get; set; }
}
