using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetGraphQL.Services.Models.OrderDetail;

namespace NetGraphQL.Services.Models.Order
{
    public class OrderRequest
    {
        public int CustomerId { get; set; }
        public List<CreateOrderDetailRequest> OrderDetails { get; set; }
    }
}
