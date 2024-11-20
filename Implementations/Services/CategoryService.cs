using MyStore.Abstractions.Repositories;
using MyStore.Abstractions.Services;
using MyStore.Dtos.Category;
using MyStore.Implementations.Repositories;
using MyStore.Models;

namespace MyStore.Implementations.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService (ICategoryRepository repository)
        {
            _repository = repository;
        }

        public CategoryDto Create(CreateCategoryDto createCategoryDto)
        {
            var category = _repository.Create(createCategoryDto);
            var CategoryDto = new CategoryDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                CreatedDateTime = DateTime.Now,
                ModifiedDateTime = DateTime.Now,
            };
            return CategoryDto;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<CategoryDto> Get()
        {
            var categories = _repository.Get();
            var CategoryDto = new List<CategoryDto>();

            foreach (Category category in categories)
            {
                var result = new CategoryDto
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName,
                    CreatedDateTime = category.CreatedDateTime,
                    ModifiedDateTime = category.ModifiedDateTime,
                };
                CategoryDto.Add(result);
            }
            return CategoryDto;

        }

        public Category GetById(int id)
        {
            return _repository.GetById(id);
        }

        public CategoryDto Update(int id, UpdateCategoryDto updateCategoryDto)
        {
            var category = _repository.Update(id, updateCategoryDto);
            var CategoryDto = new CategoryDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                CreatedDateTime = category.CreatedDateTime,
                ModifiedDateTime = category.ModifiedDateTime
            };
            return CategoryDto;
        }
    }
}
