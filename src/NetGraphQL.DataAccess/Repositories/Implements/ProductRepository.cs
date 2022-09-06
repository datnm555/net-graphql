using NetGraphQL.Domain.Context;
using NetGraphQL.Domain.Entities;

namespace NetGraphQL.DataAccess.Repositories.Implements;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}