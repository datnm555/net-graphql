using NetGraphQL.Services.GraphQL.Types.OrderDetail;

namespace NetGraphQL.Services.GraphQL.Types.Order;

public class OrderType : ObjectGraphType<Domain.Entities.Order>
{
    public OrderType(IOrderDetailService orderDetailService)
    {
        Field(p => p.Id);
        Field(p => p.CustomerId);
        FieldAsync<ListGraphType<OrderDetailType>>(
            "orderDetails",
            resolve: async context => await orderDetailService.GetOrderDetailsByOrderId(context.Source.Id)
        );
    }
}