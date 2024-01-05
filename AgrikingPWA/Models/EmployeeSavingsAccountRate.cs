using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmployeeSavingsAccountRate
{
    public int Id { get; set; }

    public DateTime EffectiveDateTime { get; set; }

    public decimal Rate { get; set; }
}
