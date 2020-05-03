using Microsoft.Extensions.DependencyInjection;
using UseCases.Interfaces;
using UseCases.Services;
using UseCases.UseCases;

namespace UseCases
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterUseCasesServices(this IServiceCollection services)
        {
            services.AddScoped<IAddToDoItemUseCase, AddToDoItemUseCase>();
            services.AddScoped<ICalendarService, CalendarService>();

            return services;
        }
    }
}
