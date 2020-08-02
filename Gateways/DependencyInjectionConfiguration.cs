﻿using Gateways.Services;
using Microsoft.Extensions.DependencyInjection;
using UseCases.Interfaces;

namespace Gateways
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection RegisterGatewaysServices(this IServiceCollection services)
        {
            services.AddScoped<IToDoItemPersistenceService, ToDoItemPersistenceService>();

            services.AddDbContext<ToDoContext>();

            return services;
        }
    }
}