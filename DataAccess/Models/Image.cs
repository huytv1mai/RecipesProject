using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Image
{
    public int ImageId { get; set; }

    public string? ImageName { get; set; }

    public int? RecipeId { get; set; }

    public string? ImageIndex { get; set; }

    public virtual Recipe? Recipe { get; set; }
}
