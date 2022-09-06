using NetGraphQL.Domain.Context;
using NetGraphQL.Domain.Entities;

namespace NetGraphQL.DataAccess.Repositories.Implements;

public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}