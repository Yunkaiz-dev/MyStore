using Microsoft.EntityFrameworkCore;
using MyStore.Abstractions.Repositories;
using MyStore.Dtos.Category;
using MyStore.Models;

namespace MyStore.Implementations.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreDbContext _dbContext;

        public CategoryRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Category Create(CreateCategoryDto createCategoryDto)
        {
            var result = new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                CreatedDateTime = DateTime.Now,
                ModifiedDateTime = DateTime.UtcNow,
            };
            _dbContext.Add(result);
            _dbContext.SaveChanges();
            return result;
        }
        public Category Update(int id,UpdateCategoryDto updateCategoryDto)
        {
            var CategoryExist = GetById(id);

            CategoryExist.CategoryName = updateCategoryDto.CategoryName ?? CategoryExist.CategoryName;
            CategoryExist.CreatedDateTime = updateCategoryDto.CreatedDateTime ?? CategoryExist.CreatedDateTime;
            CategoryExist.ModifiedDateTime = updateCategoryDto.ModifiedDateTime ?? CategoryExist.ModifiedDateTime;

            _dbContext.Update(CategoryExist);
            _dbContext.SaveChanges();

            var UpdatedCategory = GetById(id);
            return UpdatedCategory;
        }

        public void Delete(int id)
        {
            Category category = GetById(id);
            _dbContext.Remove(category);
            _dbContext.SaveChanges();
        }

        public List<Category> Get()
        {
            return [.. _dbContext.Categories];
        }

        public Category GetById(int id)
        {
            return _dbContext.Categories.Where(p => p.CategoryId == id).FirstOrDefault();
        }

    }
}
