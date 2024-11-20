using MyStore.Dtos.Category;
using MyStore.Models;

namespace MyStore.Abstractions.Services
{
    public interface ICategoryService
    {
        List<CategoryDto> Get();

        Category GetById(int id);

        CategoryDto Create(CreateCategoryDto createCategoryDto);

        CategoryDto Update(int id, UpdateCategoryDto updateCategoryDto);

        void Delete(int id);
    }
}
