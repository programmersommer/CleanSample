using Gateways.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UseCases.Interfaces;

namespace Gateways
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection RegisterGatewaysServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IToDoItemPersistenceService, ToDoItemPersistenceService>();

            services.AddDbContext<ToDoContext>(options => options.UseSqlite(configuration.GetConnectionString("ToDoDatabase")));

            return services;
        }
    }
}
