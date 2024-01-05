using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ImportLog
{
    public int Id { get; set; }

    public string? Process { get; set; }

    public DateTime Date { get; set; }

    public string? Type { get; set; }

    public string? Message { get; set; }

    public string? Key { get; set; }
}
