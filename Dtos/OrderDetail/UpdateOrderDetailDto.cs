namespace MyStore.Dtos.OrderDetail
{
    public class UpdateOrderDetailDto
    {
        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public int OrderDetailQuantity { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
