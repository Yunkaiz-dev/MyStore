using System;
using System.Collections.Generic;

namespace MyStore.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserFirstName { get; set; } = null!;

    public string UserLastName { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public byte IsMember { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
