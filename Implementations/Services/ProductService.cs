using MyStore.Abstractions.Repositories;
using MyStore.Abstractions.Services;
using MyStore.Dtos.Products;
using MyStore.Models;

namespace MyStore.Implementations.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productService;

        public ProductService(IProductRepository productService)
        {
            _productService = productService;
        }

        public ProductDto Create(CreateProductDto createProductDto)
        {
            var product = _productService.Create(createProductDto);
            var productDto = new ProductDto
            {
                // Mapeo de propiedades por completar
                ProductId = product.ProductId,
                PhotoId = product.PhotoId,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                CategoryId = product.CategoryId,
                ProductPrice = product.ProductPrice,
                ProductBrand = product.ProductBrand,
                ProductStock = product.ProductStock,
                CreatedDateTime = product.CreatedDateTime,
                ModifiedDateTime = product.ModifiedDateTime,
            };
            return productDto;
        }

        public void Delete(int id)
        {
            _productService.Delete(id);
        }

        public List<ProductDto> Get()
        {
            var products = _productService.Get();
            var productDtos = new List<ProductDto>();

            foreach (Product product in products)
            {
                var dto = new ProductDto
                {
                    // Mapeo de propiedades por completar
                    ProductId = product.ProductId,
                    PhotoId = product.PhotoId,
                    ProductName = product.ProductName,
                    ProductDescription = product.ProductDescription,
                    CategoryId = product.CategoryId,
                    ProductPrice = product.ProductPrice,
                    ProductBrand = product.ProductBrand,
                    ProductStock = product.ProductStock,
                    CreatedDateTime = product.CreatedDateTime,
                    ModifiedDateTime = product.ModifiedDateTime,
                };
                productDtos.Add(dto);
            }
            return productDtos;
        }

        public Product GetById(int id)
        {
            return _productService.GetById(id);
        }

        public ProductDto Update(int id, UpdateProductDto updateProductDto)
        {
            var product = _productService.Update(id, updateProductDto);
            var productDto = new ProductDto
            {
                // Mapeo de propiedades por completar
                ProductId = product.ProductId,
                PhotoId = product.PhotoId,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                CategoryId = product.CategoryId,
                ProductPrice = product.ProductPrice,
                ProductBrand = product.ProductBrand,
                ProductStock = product.ProductStock,
                CreatedDateTime = product.CreatedDateTime,
                ModifiedDateTime = product.ModifiedDateTime,
            };
            return productDto;
        }

    }
}
