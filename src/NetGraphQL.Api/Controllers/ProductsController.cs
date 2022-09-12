using NetGraphQL.Services.Models.Product;

namespace NetGraphQL.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        return Ok(await _productService.GetProducts());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(int id)
    {
        return Ok(await _productService.GetProductById(id));
    }

    [HttpPut("update-product/{id}")]
    public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductRequest productRequest)
    {
        return Ok(await _productService.UpdateProduct(id, productRequest));
    }

    [HttpPost("create-product")]
    public async Task<IActionResult> CreateProduct([FromBody] ProductRequest productRequest)
    {
        return Ok(await _productService.CreateProduct(productRequest));
    }
}