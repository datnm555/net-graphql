using Microsoft.EntityFrameworkCore;

namespace NetGraphQL.Services.Implements;

public class OrderService : IOrderService
{
    private  readonly  IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<List<Order>> GetOrders()
    {
        var products = await _orderRepository.GetAllAsync();
        return products.ToList();
    }

    public async Task<Order> GetOrderById(int id)
    {
        return await _orderRepository.Find(x=>x.Id == id).Include(x=>x.OrderDetails).FirstOrDefaultAsync();
    }

    public async Task<Order> UpdateOrder(int id, Order order)
    {
        var orderUpdate = await _orderRepository.GetByIdAsync(id);
        await _orderRepository.UpdateAsync(orderUpdate);
        return orderUpdate;
    }

    public async Task<Order> CreateOrder(Order order)
    {
        await _orderRepository.AddAsync(order);

        return order;
    }
}