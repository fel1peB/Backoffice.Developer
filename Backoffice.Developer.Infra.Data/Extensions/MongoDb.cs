using Microsoft.Extensions.DependencyInjection;

namespace Backoffice.Developer.Infra.Data.Extensions
{
    public static class MongoDb
    {
        public static IServiceCollection AddMongoDB<TRepo>(
            this IServiceCollection services,
            Settings mongoSettings
        )
        {
            services.AddTransient(services => mongoSettings);
            services.AddTransient(typeof(TRepo));

            return services;
        }
        public static IServiceCollection AddServices<TService>(
           this IServiceCollection services)
        {
            services.AddTransient(typeof(TService));

            return services;
        }
    }
}
