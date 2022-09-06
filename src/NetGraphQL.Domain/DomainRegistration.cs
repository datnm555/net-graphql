using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetGraphQL.Domain.Context;

namespace NetGraphQL.Domain
{
    public static class DomainRegistration
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opts =>
            {
                opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
