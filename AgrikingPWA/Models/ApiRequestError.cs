using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ApiRequestError
{
    public int Id { get; set; }

    public int ApiRequestId { get; set; }

    public DateTime? ErrorDateTime { get; set; }

    public string? ErrorText { get; set; }

    public virtual ApiRequest ApiRequest { get; set; } = null!;
}
