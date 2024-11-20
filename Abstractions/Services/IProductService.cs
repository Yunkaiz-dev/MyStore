using MyStore.Dtos.Products;
using MyStore.Models;

namespace MyStore.Abstractions.Services
{
    public interface IProductService
    {
        List<ProductDto> Get();

        Product GetById(int id);

        ProductDto Create(CreateProductDto createProductDto);

        ProductDto Update(int id, UpdateProductDto updateProductDto);

        void Delete(int id);
    }
}
