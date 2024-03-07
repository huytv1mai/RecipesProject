using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Faq
{
    public int Faqid { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
