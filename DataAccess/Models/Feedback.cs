using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public int UserId { get; set; }

    public int RecipeId { get; set; }

    public string Comment { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
