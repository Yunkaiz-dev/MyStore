using System;
using System.Collections.Generic;

namespace MyStore.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
