using GraphQL.Types;
using NetGraphQL.Services.GraphQL.Queries;

namespace NetGraphQL.Services.GraphQL.Schemas;

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