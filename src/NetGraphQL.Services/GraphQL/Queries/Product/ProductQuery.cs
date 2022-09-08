using System.Formats.Asn1;
using GraphQL;
using GraphQL.Types;
using NetGraphQL.Services.GraphQL.Types.Product;

namespace NetGraphQL.Services.GraphQL.Queries.Product;

public class ProductQuery : ObjectGraphType
{
    public ProductQuery(IProductService productService)
    {
        //_productService = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<IProductService>();
        //get all
        FieldAsync<ListGraphType<ProductType>>("products", resolve: async context => await productService.GetProducts());


        //get product by id
        FieldAsync<ProductType>(
            "product",
            arguments: new QueryArguments(new QueryArgument<IntGraphType>
            {
                Name = "id"
            }),
            resolve: async context => await productService.GetProductById(context.GetArgument<int>("id")));
    }

}