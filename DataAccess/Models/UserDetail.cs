using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class UserDetail
{
    public int UserId { get; set; }

    public string FristName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public bool Sex { get; set; }

    public DateOnly BirthOfDate { get; set; }

    public string Email { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
