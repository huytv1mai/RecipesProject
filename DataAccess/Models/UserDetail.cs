using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class UserDetail
{
    public int UserId { get; set; }

    public string? FristName { get; set; }

    public string? LastName { get; set; }

    public bool? Sex { get; set; }

    public DateTime? BirthOfDate { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public virtual User User { get; set; } = null!;
}
