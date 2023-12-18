﻿
using DesafioCurso.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;


namespace DesafioCurso.Infra.Ioc.Repository
{
    internal static class Startup
    {
        internal static IServiceCollection AddServiceRepository(this IServiceCollection services)
        {
            services.AddScoped<UnitRepository>();

            return services;
        }
    }
}