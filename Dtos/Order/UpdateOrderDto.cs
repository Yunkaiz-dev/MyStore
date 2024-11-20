namespace MyStore.Dtos.Order
{
    public class UpdateOrderDto
    {
        public int? UserId { get; set; }

        public decimal? OrderTotal { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
