using MyStore.Dtos.Category;
using MyStore.Models;

namespace MyStore.Abstractions.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> Get();

        Category GetById(int id);

        Category Create(CreateCategoryDto createCategoryDto);

        Category Update(int id, UpdateCategoryDto updateCategoryDto);

        void Delete(int id);
    }
}
