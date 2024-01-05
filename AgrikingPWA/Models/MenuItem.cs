using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class MenuItem
{
    public int Id { get; set; }

    public string MenuText { get; set; } = null!;

    public string? ControllerName { get; set; }

    public string? ActionName { get; set; }

    public string? IconId { get; set; }

    public string? TargetId { get; set; }

    public int Order { get; set; }

    public int? ParentId { get; set; }

    public bool Development { get; set; }

    public bool Production { get; set; }

    public virtual MenuIcon? Icon { get; set; }

    public virtual ICollection<MenuItem> InverseParent { get; set; } = new List<MenuItem>();

    public virtual ICollection<MenuItemUserGroup> MenuItemUserGroups { get; set; } = new List<MenuItemUserGroup>();

    public virtual MenuItem? Parent { get; set; }

    public virtual MenuTarget? Target { get; set; }
}
