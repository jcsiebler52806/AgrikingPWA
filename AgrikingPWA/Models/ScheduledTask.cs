using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ScheduledTask
{
    public int Id { get; set; }

    public string? TaskName { get; set; }

    public string? TaskRunner { get; set; }

    public int? ScheduleTimeId { get; set; }

    public bool OnMonday { get; set; }

    public bool OnTuesday { get; set; }

    public bool OnWednesday { get; set; }

    public bool OnThursday { get; set; }

    public bool OnFriday { get; set; }

    public bool OnSaturday { get; set; }

    public bool OnSunday { get; set; }

    public bool IsDisabled { get; set; }

    public bool SendTaskLog { get; set; }

    public virtual ScheduledTaskTime? ScheduleTime { get; set; }

    public virtual ICollection<ScheduledTaskJob> ScheduledTaskJobs { get; set; } = new List<ScheduledTaskJob>();

    public virtual ICollection<ScheduledTaskParameter> ScheduledTaskParameters { get; set; } = new List<ScheduledTaskParameter>();
}
