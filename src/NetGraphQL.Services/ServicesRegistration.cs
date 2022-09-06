using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetGraphQL.Domain.Context;
using NetGraphQL.Services.Implements;

namespace NetGraphQL.Services
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddServiceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            return services;
        }
    }
}
