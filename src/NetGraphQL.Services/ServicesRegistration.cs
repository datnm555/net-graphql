using GraphQL.Server;
using GraphQL.Types;
using NetGraphQL.Services.GraphQL.Queries.Product;
using NetGraphQL.Services.GraphQL.Schemas.Product;
using NetGraphQL.Services.GraphQL.Types.Product;

namespace NetGraphQL.Services
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddServiceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();


            services.AddSingleton<ProductType>();
            services.AddSingleton<ProductQuery>();
            services.AddSingleton<ISchema, ProductSchema>();

            services.AddGraphQL(ops =>
            {
                ops.EnableMetrics = false;
            });
            return services;
        }
    }
}
