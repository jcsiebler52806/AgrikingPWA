using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string? Image { get; set; }

    public string? StartupUrl { get; set; }

    public string? StatusId { get; set; }

    public string? TypeId { get; set; }

    public string? EmployeeId { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? TestUserId { get; set; }

    public bool Inactive { get; set; }

    public DateTime? LastActiveDateTime { get; set; }

    public string? Hash { get; set; }

    public string? Salt { get; set; }

    public virtual ICollection<Audit> Audits { get; set; } = new List<Audit>();

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<LabSpecialAnalysisRequest> LabSpecialAnalysisRequests { get; set; } = new List<LabSpecialAnalysisRequest>();

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ICollection<ReportGroupAssignment> ReportGroupAssignments { get; set; } = new List<ReportGroupAssignment>();

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public virtual ICollection<SampleResultExportTemplate> SampleResultExportTemplates { get; set; } = new List<SampleResultExportTemplate>();

    public virtual UserStatus? Status { get; set; }

    public virtual UserType? Type { get; set; }

    public virtual ICollection<UserKeyValue> UserKeyValues { get; set; } = new List<UserKeyValue>();

    public virtual ICollection<UserMessage> UserMessages { get; set; } = new List<UserMessage>();

    public virtual ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();
}
