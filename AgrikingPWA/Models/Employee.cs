using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Employee
{
    public string Id { get; set; } = null!;

    public string First { get; set; } = null!;

    public string? Nickname { get; set; }

    public string? Middle { get; set; }

    public string Last { get; set; } = null!;

    public string? Title { get; set; }

    public string TaxId { get; set; } = null!;

    public DateTime? BirthDate { get; set; }

    public string? GenderId { get; set; }

    public string? MaritalStatusId { get; set; }

    public string? SpouseFirst { get; set; }

    public string? SpouseNickname { get; set; }

    public string? SpouseMiddle { get; set; }

    public string? SpouseLast { get; set; }

    public string? SpouseTitle { get; set; }

    public DateTime? SpouseBirthDate { get; set; }

    public DateTime? FullTimeHired { get; set; }

    public DateTime? PartTimeHired { get; set; }

    public DateTime? Terminated { get; set; }

    public string? TypeId { get; set; }

    public string? StatusId { get; set; }

    public string? SubsidiaryId { get; set; }

    public string? DepartmentId { get; set; }

    public string? UserId { get; set; }

    public string? NetSuiteId { get; set; }

    public string? DisplayName { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<DepartmentManager> DepartmentManagers { get; set; } = new List<DepartmentManager>();

    public virtual ICollection<EmployeeAddress> EmployeeAddresses { get; set; } = new List<EmployeeAddress>();

    public virtual ICollection<EmployeeContact> EmployeeContacts { get; set; } = new List<EmployeeContact>();

    public virtual ICollection<EmployeeDepartment> EmployeeDepartments { get; set; } = new List<EmployeeDepartment>();

    public virtual ICollection<EmployeeJobTitle> EmployeeJobTitles { get; set; } = new List<EmployeeJobTitle>();

    public virtual ICollection<EmployeeSavingsAccount> EmployeeSavingsAccounts { get; set; } = new List<EmployeeSavingsAccount>();

    public virtual ICollection<EmployeeTerm> EmployeeTerms { get; set; } = new List<EmployeeTerm>();

    public virtual ICollection<EmployeeTimeEntry> EmployeeTimeEntries { get; set; } = new List<EmployeeTimeEntry>();

    public virtual Gender? Gender { get; set; }

    public virtual MaritalStatus? MaritalStatus { get; set; }

    public virtual ICollection<Salesperson> Salespeople { get; set; } = new List<Salesperson>();

    public virtual ICollection<SmartCheckEmployee> SmartCheckEmployees { get; set; } = new List<SmartCheckEmployee>();

    public virtual EmployeeStatus? Status { get; set; }

    public virtual Subsidiary? Subsidiary { get; set; }

    public virtual EmployeeType? Type { get; set; }

    public virtual User? User { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
