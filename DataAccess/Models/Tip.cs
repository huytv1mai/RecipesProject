using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Tip
{
    public int TipId { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateOnly DatePosted { get; set; }

    public int UseId { get; set; }

    public virtual User Use { get; set; } = null!;
}
