using System.Security.AccessControl;
using Microsoft.EntityFrameworkCore;
using NetGraphQL.Services.Models.Order;
using NetGraphQL.Services.Models.Product;

namespace NetGraphQL.Services.Implements;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IOrderDetailRepository _orderDetailRepository;

    public OrderService(IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository)
    {
        _orderRepository = orderRepository;
        _orderDetailRepository = orderDetailRepository;
    }

    public async Task<List<Order>> GetOrders()
    {
        var products = await _orderRepository.GetAllAsync();
        return products.ToList();
    }

    public async Task<Order> GetOrderById(int id)
    {
        //var order = await _orderRepository.Find(x => x.Id == id).Include(x => x.OrderDetails).FirstOrDefaultAsync();

        //var orderDetails = await _orderDetailRepository.Find(x => x.OrderId == order.Id).Include(x => x.Product)
        //    .ToListAsync();

        //order.OrderDetails = orderDetails;
        var order = await _orderRepository.GetByIdAsync(id);
        return order;
    }

    public async Task<Order> UpdateOrder(int id, OrderRequest orderRequest)
    {

        if (id == 0)
            throw new ArgumentNullException(nameof(id));
        if (orderRequest == null)
            throw new ArgumentNullException(nameof(orderRequest));

        var orderUpdate = await _orderRepository.GetByIdAsync(id);
        //orderUpdate.CustomerId = orderRequest.CustomerId;

        await _orderRepository.UpdateAsync(orderUpdate);
        return orderUpdate;
    }

    public async Task<Order> CreateOrder(OrderRequest orderRequest)
    {
        if (orderRequest == null)
            throw new ArgumentNullException(nameof(orderRequest));

        var orderCreate = new Order();
        orderCreate.CustomerId = orderRequest.CustomerId;
        //order.OrderDetails.
        await _orderRepository.AddAsync(orderCreate);

        orderCreate.OrderDetails = new List<OrderDetail>();
        foreach (var item in orderRequest.OrderDetails)
        {
            orderCreate.OrderDetails.Add(new OrderDetail()
            {
                OrderId = orderCreate.Id,
                ProductId = item.ProductId
            });
        }
        await _orderRepository.SaveChangeAsync();

        return orderCreate;
    }
}