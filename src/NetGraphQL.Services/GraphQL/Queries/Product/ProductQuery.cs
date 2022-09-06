﻿using GraphQL;
using GraphQL.Types;
using NetGraphQL.Services.GraphQL.Types.Product;

namespace NetGraphQL.Services.GraphQL.Queries.Product;

public class ProductQuery : ObjectGraphType
{
    public ProductQuery(IProductService productService)
    {

        Field<ListGraphType<ProductType>>("products", resolve: context => productService.GetProducts());

        Field<ProductType>(
            "product",
            arguments: new QueryArguments(new QueryArgument<IntGraphType>
            {
                Name = "id"
            }),
            resolve: context => productService.GetProductById(context.GetArgument<int>("id")));
    }
}