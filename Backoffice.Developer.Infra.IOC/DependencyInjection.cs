using Backoffice.Developer.Application.Interface;
using Backoffice.Developer.Application.Repository;
using Backoffice.Developer.Application.Service;
using Backoffice.Developer.Infra.Data;
using Backoffice.Developer.Infra.Data.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Backoffice.Developer.Infra.IOC
{
    public static class DependencyInjection
    {
        private static string MongoCofigurationSection = "Mongo";
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            var mongodbSettings = new Settings();
            configuration.GetSection(MongoCofigurationSection).Bind(mongodbSettings);
            services.AddMongoDB<DeveloperRepository>(mongodbSettings);
            services.AddScoped<IDeveloperService, DeveloperService>();


            var developerMap = new DeveloperMap();
            developerMap.Configure();
            return services;
        }
    }
}
