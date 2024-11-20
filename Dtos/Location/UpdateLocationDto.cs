namespace MyStore.Dtos.Location
{
    public class UpdateLocationDto
    {
        public int? UserId { get; set; }

        public string LocationStreet { get; set; } = null!;

        public string LocationState { get; set; } = null!;

        public int LocationZip { get; set; }

        public string LocationCountry { get; set; } = null!;

        public DateTime? CreatedDateTime { get; set; }

        public DateTime? ModifiedDateTime { get; set; }
    }
}
