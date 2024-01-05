using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class UserMessage
{
    public int Id { get; set; }

    public string? SentFrom { get; set; }

    public string? SentTo { get; set; }

    public string? MessageBody { get; set; }

    public DateTime? SentDateTime { get; set; }

    public DateTime? ReceivedDateTime { get; set; }

    public virtual User? SentFromNavigation { get; set; }
}
