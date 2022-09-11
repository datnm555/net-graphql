using GraphQL.MicrosoftDI;
using NetGraphQL.Services.GraphQL.Schemas;

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
            services.AddTransient<OrderType>();
            services.AddTransient<ProductQuery>();
            services.AddTransient<OrderQuery>();

            services.AddTransient<RootQuery>();
            services.AddTransient<ISchema, RootSchema>();

            services.AddGraphQL(ops =>
            {
                ops.AddSystemTextJson();
            });

      
         

            return services;
        }
    }
}
