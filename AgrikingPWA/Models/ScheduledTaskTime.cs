using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ScheduledTaskTime
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int Order { get; set; }

    public int Hour { get; set; }

    public virtual ICollection<ScheduledTask> ScheduledTasks { get; set; } = new List<ScheduledTask>();
}
