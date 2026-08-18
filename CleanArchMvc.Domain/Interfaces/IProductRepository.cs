using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Interfaces;

public interface IProductRepository
{

    Task<Product?> GetProductByIdAsync(int? id);
    Task<Product?> GetProductCategoryAsync(int? id);
    Task<IEnumerable<Product>> GetProductsAsync();
    
    Task<Product> CreateProductAsync(Product product);
    Task<Product> UpdateProductAsync(Product product);
    Task<Product> DeleteProductAsync(Product product);
}