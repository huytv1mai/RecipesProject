using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Contest
{
    public int ContestId { get; set; }

    public string ContestName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();
}
