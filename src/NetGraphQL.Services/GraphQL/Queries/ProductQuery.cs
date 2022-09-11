using System.Formats.Asn1;

namespace NetGraphQL.Services.GraphQL.Queries;

public class ProductQuery : ObjectGraphType
{
    public ProductQuery(IProductService productService)
    {
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