using GraphQL.Types;
using NetGraphQL.Services.GraphQL.Queries.Product;

namespace NetGraphQL.Services.GraphQL.Schemas.Product;

public class ProductSchema : Schema
{
    public ProductSchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        Query = serviceProvider.GetRequiredService<ProductQuery>();
    }

    //public ProductSchema(ProductQuery productQuery)
    //{
    //    Query = productQuery;
    //}
}