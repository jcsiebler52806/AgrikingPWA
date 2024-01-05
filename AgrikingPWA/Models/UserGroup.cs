using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class UserGroup
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<MenuItemUserGroup> MenuItemUserGroups { get; set; } = new List<MenuItemUserGroup>();

    public virtual ICollection<ReportGroupAssignment> ReportGroupAssignments { get; set; } = new List<ReportGroupAssignment>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
