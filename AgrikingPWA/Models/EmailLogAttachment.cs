using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmailLogAttachment
{
    public int Id { get; set; }

    public int EmailLogId { get; set; }

    public byte[]? Attachment { get; set; }

    public string? AttachmentName { get; set; }

    public virtual EmailLog EmailLog { get; set; } = null!;
}
