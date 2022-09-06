namespace NetGraphQL.Services.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetProducts();
    Task<Product> GetProductById(int id);
    Task<Product> CreateProduct(Product product);
    Task<Product> UpdateProduct(int id, Product product);
}