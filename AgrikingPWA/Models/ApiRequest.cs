using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ApiRequest
{
    public int Id { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public string? RequestBody { get; set; }

    public string? ActionName { get; set; }

    public string? ControllerName { get; set; }

    public string? RequestStatus { get; set; }

    public virtual ICollection<ApiRequestError> ApiRequestErrors { get; set; } = new List<ApiRequestError>();
}
