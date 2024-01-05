using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class Email
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Sender { get; set; }

    public string? Subject { get; set; }

    public string? Content { get; set; }

    public virtual ICollection<EmailRecipient> EmailRecipients { get; set; } = new List<EmailRecipient>();
}
