using System;
using System.Collections.Generic;

namespace MyStore.Models;

public partial class Photo
{
    public int PhotoId { get; set; }

    public string PhotoName { get; set; } = null!;

    public string PhotoUrl { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
