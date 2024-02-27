using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Image
{
    public int ImageId { get; set; }

    public string ImageName { get; set; } = null!;

    public int RecipeId { get; set; }

    public string ImageIndex { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;
}
