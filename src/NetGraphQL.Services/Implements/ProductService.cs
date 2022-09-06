using NetGraphQL.Domain.Entities;

namespace NetGraphQL.Services.Implements;

public class ProductService : IProductService
{
    public async Task<List<Product>> GetProducts()
    {
        return new List<Product>();
    }

    public async Task<Product> GetProductById(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> CreateProduct(Product product)
    {
        return new Product();
    }

    public async Task<Product> UpdateProduct(int id, Product product)
    {
        return new Product();
    }
}