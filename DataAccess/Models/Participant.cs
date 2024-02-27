using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Participant
{
    public int ParticipantId { get; set; }

    public int UserId { get; set; }

    public int ContestId { get; set; }

    public bool SubmissionType { get; set; }

    public string SubmissionContent { get; set; } = null!;

    public DateOnly SubmissionDate { get; set; }

    public virtual Contest Contest { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
