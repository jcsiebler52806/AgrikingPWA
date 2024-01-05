using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class FileUploadType
{
    public string Id { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Active { get; set; }

    public bool Default { get; set; }

    public int Order { get; set; }

    public virtual ICollection<FileUpload> FileUploads { get; set; } = new List<FileUpload>();
}
