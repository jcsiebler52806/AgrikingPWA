using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class MenuItemUserGroup
{
    public int MenuItemId { get; set; }

    public string UserGroupId { get; set; } = null!;

    public bool AllowRead { get; set; }

    public bool AllowCreate { get; set; }

    public bool AllowEdit { get; set; }

    public bool AllowDelete { get; set; }

    public bool AllowImport { get; set; }

    public bool AllowExport { get; set; }

    public bool AllowComment { get; set; }

    public virtual MenuItem MenuItem { get; set; } = null!;

    public virtual UserGroup UserGroup { get; set; } = null!;
}
