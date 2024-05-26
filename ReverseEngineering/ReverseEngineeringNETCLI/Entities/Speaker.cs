using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReverseEngineeringNETCLI.Entities;

public partial class Speaker
{
    [Key]
    [Column("SpeakerID")]
    public int SpeakerId { get; set; }

    [StringLength(25)]
    public string FirstName { get; set; } = null!;

    [StringLength(25)]
    public string LastName { get; set; } = null!;

    [InverseProperty("Speaker")]
    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
