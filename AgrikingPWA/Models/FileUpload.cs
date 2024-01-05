using System;
using System.Collections.Generic;

namespace AgriKingApp.Models;

public partial class FileUpload
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public DateTime UploadDateTime { get; set; }

    public string? FilePath { get; set; }

    public string? FileUploadTypeId { get; set; }

    public string? FileName { get; set; }

    public string? SampleIdMax { get; set; }

    public string? SampleIdMin { get; set; }

    public virtual FileUploadType? FileUploadType { get; set; }
}
