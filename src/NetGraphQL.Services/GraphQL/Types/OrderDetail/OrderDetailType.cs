namespace NetGraphQL.Services.GraphQL.Types.OrderDetail
{
    internal class OrderDetailType : ObjectGraphType<Domain.Entities.OrderDetail>
    {
        public OrderDetailType()
        {
            Field(p => p.Id);
            Field(p => p.OrderId);
            Field(p => p.ProductId);
            Field(p => p.Product);
            //Field(p => p.OrderDetails);
        }
    }
}