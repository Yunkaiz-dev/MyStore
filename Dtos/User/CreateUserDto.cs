namespace MyStore.Dtos.User
{
    public class CreateUserDto
    {
        public string UserFirstName { get; set; } = null!;

        public string UserLastName { get; set; } = null!;

        public string UserEmail { get; set; } = null!;

        public byte IsMember { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
