using NetGraphQL.Domain.Context;
using NetGraphQL.Domain.Entities;

namespace NetGraphQL.DataAccess.Repositories.Implements;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}