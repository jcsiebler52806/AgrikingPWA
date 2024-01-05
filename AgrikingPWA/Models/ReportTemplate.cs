using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class ReportTemplate
{
    public int Id { get; set; }

    public string? CreatedBy { get; set; }

    public string? TemplateName { get; set; }

    public bool Global { get; set; }

    public virtual ICollection<ReportTemplateDetail> ReportTemplateDetails { get; set; } = new List<ReportTemplateDetail>();
}
