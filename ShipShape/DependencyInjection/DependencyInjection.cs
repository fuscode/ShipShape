﻿using ShipShape.Application.Cities;
using ShipShape.Infra.Repositories.Cities;

namespace ShipShape.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICityRepository, CityRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICityService, CityService>();

            return services;
        }
    }
}