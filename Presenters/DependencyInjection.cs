using Microsoft.Extensions.DependencyInjection;
using Presenters.Services.Services;
using UseCases.Interfaces;

namespace Presenters
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterPresentersServices(this IServiceCollection services)
        {
            services.AddScoped<IToDoHubService, ToDoHubService>();

            return services;
        }
    }
}
