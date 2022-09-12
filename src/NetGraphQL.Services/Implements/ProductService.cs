using NetGraphQL.Services.Models.Product;

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

    public async Task<Product> CreateProduct(ProductRequest productRequest)
    {
        if (productRequest == null)
            throw new ArgumentNullException(nameof(productRequest));
        var product = new Product();
        product.Name = productRequest.Name;
        product.Price = productRequest.Price;
        await _productRepository.AddAsync(product);
        return product;
    }

    public async Task<Product> UpdateProduct(int id, ProductRequest productRequest)
    {
        if (id == 0)
            throw new ArgumentNullException(nameof(id));
        if (productRequest == null)
            throw new ArgumentNullException(nameof(productRequest));

        var productUpdate = await _productRepository.GetByIdAsync(id);
        productUpdate.Name = productRequest.Name;
        productUpdate.Price = productRequest.Price;
        await _productRepository.UpdateAsync(productUpdate);
        return productUpdate;
    }
}