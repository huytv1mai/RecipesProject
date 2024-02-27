using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Recipe
{
    public int RecipeId { get; set; }

    public string Title { get; set; } = null!;

    public string Details { get; set; } = null!;

    public string Ingredients { get; set; } = null!;

    public DateTime DatePosted { get; set; }

    public bool Status { get; set; }

    public string Type { get; set; } = null!;

    public int ContestId { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();
}
