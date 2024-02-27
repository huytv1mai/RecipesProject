using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public int SubscriptionTypeId { get; set; }

    public virtual ICollection<Announment> Announments { get; set; } = new List<Announment>();

    public virtual ICollection<Faq> Faqs { get; set; } = new List<Faq>();

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();

    public virtual Role Role { get; set; } = null!;

    public virtual Subscription SubscriptionType { get; set; } = null!;

    public virtual ICollection<Tip> Tips { get; set; } = new List<Tip>();

    public virtual UserDetail? UserDetail { get; set; }
}
