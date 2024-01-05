﻿using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class EmailRecipient
{
    public int Id { get; set; }

    public int EmailId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public virtual Email Email { get; set; } = null!;
}
