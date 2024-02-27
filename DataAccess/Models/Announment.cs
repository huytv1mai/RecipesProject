﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Announment
{
    public int AnnounmentId { get; set; }

    public int UserId { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateOnly DatePosted { get; set; }

    public virtual User User { get; set; } = null!;
}
