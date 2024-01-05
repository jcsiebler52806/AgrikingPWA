using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ReportGroupAssignment
{
    public int Id { get; set; }

    public string? UserGroupId { get; set; }

    public string? UserId { get; set; }

    public int ReportGroupId { get; set; }

    public int? DefaultReportGroup { get; set; }

    public virtual ReportGroup ReportGroup { get; set; } = null!;

    public virtual User? User { get; set; }

    public virtual UserGroup? UserGroup { get; set; }
}
