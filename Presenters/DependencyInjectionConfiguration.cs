using Microsoft.Extensions.DependencyInjection;
using Presenters.Services.Services;
using UseCases.Interfaces;

namespace Presenters
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection RegisterPresentersServices(this IServiceCollection services)
        {
            services.AddScoped<IToDoHubService, ToDoHubService>();

            return services;
        }
    }
}
