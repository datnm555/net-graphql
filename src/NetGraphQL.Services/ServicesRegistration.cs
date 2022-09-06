using System.Reflection;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetGraphQL.Domain.Context;
using NetGraphQL.Services.GraphQL.Queries.Product;
using NetGraphQL.Services.GraphQL.Schemas.Product;
using NetGraphQL.Services.GraphQL.Types.Product;
using NetGraphQL.Services.Implements;

namespace NetGraphQL.Services
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddServiceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();

            //services.AddSingleton<ProductType>();
            //services.AddSingleton<ProductQuery>();
            //services.AddSingleton<ISchema, ProductSchema>();

         
            return services;
        }
    }
}
