using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmployeesImport
{
    public string Id { get; set; } = null!;

    public string? NetSuiteId { get; set; }

    public string? DisplayName { get; set; }

    public string? Title { get; set; }

    public string First { get; set; } = null!;

    public string? Nickname { get; set; }

    public string? Middle { get; set; }

    public string Last { get; set; } = null!;

    public string TaxId { get; set; } = null!;

    public DateTime? BirthDate { get; set; }

    public string? GenderId { get; set; }

    public string? MaritalStatusId { get; set; }

    public string? SpouseTitle { get; set; }

    public string? SpouseFirst { get; set; }

    public string? SpouseNickname { get; set; }

    public string? SpouseMiddle { get; set; }

    public string? SpouseLast { get; set; }

    public DateTime? SpouseBirthDate { get; set; }

    public DateTime? FullTimeHired { get; set; }

    public DateTime? PartTimeHired { get; set; }

    public DateTime? Terminated { get; set; }

    public string? TypeId { get; set; }

    public string? StatusId { get; set; }

    public string? SubsidiaryId { get; set; }

    public string? DepartmentId { get; set; }

    public string? UserId { get; set; }
}
