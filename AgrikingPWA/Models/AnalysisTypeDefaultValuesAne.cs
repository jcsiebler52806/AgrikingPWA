using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class AnalysisTypeDefaultValuesAne
{
    public int Id { get; set; }

    public int IngredientNumber { get; set; }

    public int CustomerLabCodeId { get; set; }

    public string? AnalysisTypeId { get; set; }

    public decimal DefaultValue { get; set; }
}
