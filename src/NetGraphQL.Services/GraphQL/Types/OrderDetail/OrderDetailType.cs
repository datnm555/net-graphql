namespace NetGraphQL.Services.GraphQL.Types.OrderDetail
{
    internal class OrderDetailType : ObjectGraphType<Domain.Entities.OrderDetail>
    {
        public OrderDetailType(IProductService productService)
        {
            Field(p => p.OrderDetailId);
            Field(p => p.OrderId);
            Field(p => p.ProductId);
            FieldAsync<ProductType>("product",
                resolve: async context => await productService.GetProductById(context.Source.ProductId));
            //Field(p => p.OrderDetails);
        }
    }
}