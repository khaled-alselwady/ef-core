using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReverseEngineeringNETCLI.Entities;

public partial class Event
{
    [Key]
    [Column("EventID")]
    public int EventId { get; set; }

    [StringLength(255)]
    public string Title { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndAt { get; set; }

    [Column("SpeakerID")]
    public int SpeakerId { get; set; }

    [ForeignKey("SpeakerId")]
    [InverseProperty("Events")]
    public virtual Speaker Speaker { get; set; } = null!;
}
