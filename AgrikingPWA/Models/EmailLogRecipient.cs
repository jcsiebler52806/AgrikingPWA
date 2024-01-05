using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmailLogRecipient
{
    public int Id { get; set; }

    public int EmailLogId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? EmployeeId { get; set; }

    public virtual EmailLog EmailLog { get; set; } = null!;
}
