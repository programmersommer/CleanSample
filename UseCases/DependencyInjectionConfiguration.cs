using Microsoft.Extensions.DependencyInjection;
using UseCases.Interfaces;
using UseCases.Services;
using UseCases.UseCases;

namespace UseCases
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection RegisterUseCasesServices(this IServiceCollection services)
        {
            services.AddScoped<IToDoItemUseCases, ToDoItemUseCases>();
            services.AddScoped<ICalendarService, CalendarService>();

            return services;
        }
    }
}
