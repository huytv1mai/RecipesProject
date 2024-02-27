using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Subscription
{
    public int SubscriptionTypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
