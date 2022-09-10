namespace NetGraphQL.Services.Interfaces;

public interface IOrderService
{
    Task<List<Order>> GetOrders();
    Task<Order> GetOrderById(int id);
    Task<Order> UpdateOrder(int id, Order product);
    Task<Order> CreateOrder(Order product);
}