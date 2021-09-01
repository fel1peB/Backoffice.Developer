﻿using Backoffice.Developer.Application.Interface;
using Backoffice.Developer.Application.Repository;
using Backoffice.Developer.Application.Service;
using Backoffice.Developer.Infra.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Backoffice.Developer.Infra.IOC
{
    public static class DependencyInjection
    {
        private static readonly string mongoCofigurationSection = "Mongo";

        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            var mongodbSettings = new Settings();
            configuration.GetSection(mongoCofigurationSection).Bind(mongodbSettings);

            services.AddTransient(services => mongodbSettings);
            services.AddTransient(typeof(Repository<>));

            services.AddScoped<IDeveloperService, DeveloperService>();


            var developerMap = new DeveloperMap();
            developerMap.Configure();
            return services;
        }
    }
}
