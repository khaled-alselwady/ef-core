using System;
using System.Collections.Generic;

namespace ReverseEngineering.Entities;

public partial class Event
{
    public int EventID { get; set; }

    public string Title { get; set; } = null!;

    public DateTime StartAt { get; set; }

    public DateTime EndAt { get; set; }

    public int SpeakerID { get; set; }

    public virtual Speaker Speaker { get; set; } = null!;
}
