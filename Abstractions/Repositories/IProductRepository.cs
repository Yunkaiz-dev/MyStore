using MyStore.Dtos.Category;
using MyStore.Dtos.Products;
using MyStore.Models;

namespace MyStore.Abstractions.Repositories
{
    public interface IProductRepository
    {
        List<Product> Get();

        Product GetById(int id);

        Product Create(CreateProductDto createProductDto);

        Product Update(int id, UpdateProductDto updateProductDto);

        void Delete(int id);
    }
}
