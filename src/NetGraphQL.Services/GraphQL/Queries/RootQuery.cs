using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGraphQL.Services.GraphQL.Queries
{
    public  class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<OrderQuery>("orderQuery", resolve: context => new { });
            Field<ProductQuery>("productQuery", resolve: context => new { });
        }
    }
}
