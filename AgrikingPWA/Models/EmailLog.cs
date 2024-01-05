using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmailLog
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? Sender { get; set; }

    public string? Subject { get; set; }

    public string? Content { get; set; }

    public DateTime SentDateTime { get; set; }

    public virtual ICollection<EmailLogAttachment> EmailLogAttachments { get; set; } = new List<EmailLogAttachment>();

    public virtual ICollection<EmailLogRecipient> EmailLogRecipients { get; set; } = new List<EmailLogRecipient>();
}
