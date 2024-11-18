namespace MyStore.Dtos.Photo
{
    public class PhotoDto
    {
        public int PhotoId { get; set; }

        public string PhotoName { get; set; } = null!;

        public string PhotoUrl { get; set; } = null!;

        public DateTime CreateDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
