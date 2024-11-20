using MyStore.Abstractions.Repositories;
using MyStore.Dtos.Products;
using MyStore.Models;

namespace MyStore.Implementations.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly StoreDbContext _dbContext;

        public ProductRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product Create(CreateProductDto createProductDto)
        {
            var result = new Product()
            {
                // Mapeo por completar
                PhotoId = createProductDto.PhotoId,
                ProductName = createProductDto.ProductName,
                ProductDescription = createProductDto.ProductDescription,
                CategoryId = createProductDto.CategoryId,
                ProductPrice = createProductDto.ProductPrice,
                ProductBrand = createProductDto.ProductBrand,
                ProductStock = createProductDto.ProductStock,
                CreatedDateTime = createProductDto.CreatedDateTime,
                ModifiedDateTime = createProductDto.ModifiedDateTime,
            };
            _dbContext.Add(result);
            _dbContext.SaveChanges();
            return result;
        }

        public Product Update(int id, UpdateProductDto updateProductDto)
        {
            var productExist = GetById(id);

            // Mapeo por completar
            productExist.PhotoId = updateProductDto.PhotoId ?? productExist.PhotoId;
            productExist.ProductName = updateProductDto.ProductName ?? productExist.ProductName;
            productExist.ProductDescription = updateProductDto.ProductDescription ?? productExist.ProductDescription;
            productExist.CategoryId = updateProductDto.CategoryId ?? productExist.CategoryId;
            productExist.ProductPrice = updateProductDto.ProductPrice ?? productExist.ProductPrice;
            productExist.ProductBrand = updateProductDto.ProductBrand ?? productExist.ProductBrand;
            productExist.ProductStock = updateProductDto.ProductStock ?? productExist.ProductStock;
            productExist.CreatedDateTime = updateProductDto.CreatedDateTime ?? productExist.CreatedDateTime;
            productExist.ModifiedDateTime = updateProductDto.ModifiedDateTime ?? productExist.ModifiedDateTime;

            _dbContext.Update(productExist);
            _dbContext.SaveChanges();

            var updatedProduct = GetById(id);
            return updatedProduct;
        }

        public void Delete(int id)
        {
            Product product = GetById(id);
            _dbContext.Remove(product);
            _dbContext.SaveChanges();
        }

        public List<Product> Get()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _dbContext.Products.Where(p => p.ProductId == id).FirstOrDefault();
        }

    }
}
