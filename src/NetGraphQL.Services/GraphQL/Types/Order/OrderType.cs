namespace NetGraphQL.Services.GraphQL.Types.Order;

public class OrderType : ObjectGraphType<Domain.Entities.Order>
{
    public OrderType()
    {
        Field(p => p.Id);
        Field(p => p.CustomerId);
        //Field(p => p.OrderDetails);
    }
}