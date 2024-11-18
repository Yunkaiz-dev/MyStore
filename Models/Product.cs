using System;
using System.Collections.Generic;

namespace MyStore.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public int PhotoId { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public int CategoryId { get; set; }

    public decimal ProductPrice { get; set; }

    public string ProductBrand { get; set; } = null!;

    public int ProductStock { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime ModifiedDateTime { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Photo Photo { get; set; } = null!;
}
