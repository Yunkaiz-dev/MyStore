namespace MyStore.Dtos.Category
{
    public class UpdateCategoryDto
    {
        public string? CategoryName { get; set; } = null!;

        public DateTime? CreatedDateTime { get; set; }

        public DateTime? ModifiedDateTime { get; set; }
    }
}
