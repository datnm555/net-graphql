using GraphQL;
using GraphQL.MicrosoftDI;
using GraphQL.Types;
using NetGraphQL.Services.GraphQL.Queries;
using NetGraphQL.Services.GraphQL.Schemas;
using NetGraphQL.Services.GraphQL.Types.Product;

namespace NetGraphQL.Services
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddServiceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IServiceProvider>(provider => new FuncServiceProvider(provider.GetRequiredService));
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderService, OrderService>();

            services.AddTransient<ProductType>();
            services.AddTransient<ProductQuery>();
            services.AddTransient<ISchema, ProductSchema>();

            services.AddGraphQL(ops =>
            {
                ops.AddSystemTextJson();
            });

      
         

            return services;
        }
    }
}
