using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Audit
{
    public int Id { get; set; }

    public string Entity { get; set; } = null!;

    public string EntityKey1 { get; set; } = null!;

    public string? EntityKey2 { get; set; }

    public string? EntityKey3 { get; set; }

    public string? EntityKey4 { get; set; }

    public string? EntityKey5 { get; set; }

    public string? ValueBefore { get; set; }

    public string? ValueAfter { get; set; }

    public string? ControllerName { get; set; }

    public string? ActionName { get; set; }

    public string AuditAction { get; set; } = null!;

    public string? AuditUserId { get; set; }

    public DateTime AuditDateTime { get; set; }

    public string EntityField { get; set; } = null!;

    public string AuditGuid { get; set; } = null!;

    public virtual User? AuditUser { get; set; }
}
