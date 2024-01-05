using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ScheduledTaskJob
{
    public int Id { get; set; }

    public int? ScheduledTaskId { get; set; }

    public int? PercentComplete { get; set; }

    public string? StatusMessage { get; set; }

    public DateTime? StartedDateTime { get; set; }

    public DateTime? CompletedDateTime { get; set; }

    public virtual ScheduledTask? ScheduledTask { get; set; }

    public virtual ICollection<ScheduledTaskJobLog> ScheduledTaskJobLogs { get; set; } = new List<ScheduledTaskJobLog>();

    public virtual ICollection<ScheduledTaskJobParameter> ScheduledTaskJobParameters { get; set; } = new List<ScheduledTaskJobParameter>();
}
