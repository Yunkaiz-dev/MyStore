using System;
using System.Collections.Generic;

namespace MyStore.Models;

public partial class Location
{
    public int LocationId { get; set; }

    public int UserId { get; set; }

    public string LocationStreet { get; set; } = null!;

    public string LocationState { get; set; } = null!;

    public int LocationZip { get; set; }

    public string LocationCountry { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public virtual User User { get; set; } = null!;
}
