using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class MillAllocationAssociation
{
    public int Id { get; set; }

    public string? CustomerParentId { get; set; }

    public string? CustomerChildId { get; set; }

    public int TypeId { get; set; }

    public int? MillAllocationTypeId { get; set; }

    public bool Inactive { get; set; }

    public virtual MillAllocationType? MillAllocationType { get; set; }
}
