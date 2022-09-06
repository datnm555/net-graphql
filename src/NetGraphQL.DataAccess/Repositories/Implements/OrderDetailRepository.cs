namespace NetGraphQL.DataAccess.Repositories.Implements;

public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
{
    public OrderDetailRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}