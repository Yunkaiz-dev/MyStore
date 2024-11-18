namespace MyStore.Dtos.Order
{
    public class OrderDto
    {
        public int OrderId { get; set; }

        public int UserId { get; set; }

        public decimal OrderTotal { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
