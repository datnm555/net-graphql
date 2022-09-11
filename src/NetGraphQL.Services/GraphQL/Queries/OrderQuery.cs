namespace NetGraphQL.Services.GraphQL.Queries;

public class OrderQuery : ObjectGraphType
{
    public OrderQuery(IOrderService orderService)
    {
        //get all
        FieldAsync<ListGraphType<OrderType>>("orders", resolve: async context => await orderService.GetOrders());


        //get product by id
        FieldAsync<OrderType>(
            "order",
            arguments: new QueryArguments(new QueryArgument<IntGraphType>
            {
                Name = "id"
            }),
            resolve: async context => await orderService.GetOrderById(context.GetArgument<int>("id")));
    }
}