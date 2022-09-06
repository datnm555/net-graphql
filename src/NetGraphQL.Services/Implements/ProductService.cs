namespace NetGraphQL.Services.Implements;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<Product>> GetProducts()
    {
        var products = await _productRepository.GetAllAsync();
        return products.ToList();
    }

    public async Task<Product> GetProductById(int id)
    {
        return await _productRepository.GetByIdAsync(id);
    }

    public async Task<Product> CreateProduct(Product product)
    {
        await _productRepository.AddAsync(product);
        return product;
    }

    public async Task<Product> UpdateProduct(int id, Product product)
    {
        var productUpdate = await _productRepository.GetByIdAsync(id);
        productUpdate.Name = product.Name;
        productUpdate.Price = product.Price;
        await _productRepository.UpdateAsync(productUpdate);
        return productUpdate;
    }
}