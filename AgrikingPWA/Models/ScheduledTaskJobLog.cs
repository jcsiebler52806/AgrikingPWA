using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ScheduledTaskJobLog
{
    public int Id { get; set; }

    public int? ScheduledTaskJobId { get; set; }

    public DateTime? LoggedDateTime { get; set; }

    public string? LogMessage { get; set; }

    public bool IsError { get; set; }

    public bool IsWarning { get; set; }

    public virtual ScheduledTaskJob? ScheduledTaskJob { get; set; }
}
