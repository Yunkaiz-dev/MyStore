namespace MyStore.Dtos.Products
{
    public class UpdateProductDto
    {
        public int PhotoId { get; set; }

        public string ProductName { get; set; } = null!;

        public string ProductDescription { get; set; } = null!;

        public int CategoryId { get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductBrand { get; set; } = null!;

        public int ProductStock { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
