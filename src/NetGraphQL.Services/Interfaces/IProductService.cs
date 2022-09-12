using NetGraphQL.Services.Models.Product;

namespace NetGraphQL.Services.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetProducts();
    Task<Product> GetProductById(int id);
    Task<Product> CreateProduct(ProductRequest productRequest);
    Task<Product> UpdateProduct(int id, ProductRequest product);
}