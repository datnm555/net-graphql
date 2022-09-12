using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGraphQL.Services.Models.OrderDetail
{
    public class CreateOrderDetailRequest
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }

    }
}
