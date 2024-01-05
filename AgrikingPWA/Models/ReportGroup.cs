using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ReportGroup
{
    public int Id { get; set; }

    public string? GroupName { get; set; }

    public virtual ICollection<ReportGroupAssignment> ReportGroupAssignments { get; set; } = new List<ReportGroupAssignment>();
}
