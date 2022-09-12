using NetGraphQL.Services.Models.Order;

namespace NetGraphQL.Services.Interfaces;

public interface IOrderService
{
    Task<List<Order>> GetOrders();
    Task<Order> GetOrderById(int id);
    Task<Order> UpdateOrder(int id, OrderRequest orderRequest);
    Task<Order> CreateOrder(OrderRequest orderRequest);
}