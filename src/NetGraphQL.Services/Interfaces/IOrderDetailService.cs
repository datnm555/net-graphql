using NetGraphQL.Services.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGraphQL.Services.Interfaces
{
    public interface IOrderDetailService
    {
        Task<List<OrderDetail>> GetOrderDetailsByOrderId(int orderId);
    }
}
