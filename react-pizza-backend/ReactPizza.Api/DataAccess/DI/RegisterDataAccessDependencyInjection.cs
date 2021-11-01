using DataAccess.Mappers.EntityMappers;
using DataAccess.Mappers.RepositoryMappers;
using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.DI
{
    public static class RegisterDataAccessDependencyInjection
    {
        public static IServiceCollection RegisterDataAccess(this IServiceCollection services)
        {
            services
                .RegisterEntityMappers()
                .RegisterRepositoryMappers()
                .RegisterRepositories();

            return services;
        }

        private static IServiceCollection RegisterEntityMappers(this IServiceCollection services)
        {
            services.AddScoped<IPizzaComponentMapper, PizzaComponentMapper>();

            return services;
        }

        private static IServiceCollection RegisterRepositoryMappers(this IServiceCollection services)
        {
            services.AddScoped<IPizzaRepositoryMapper, PizzaRepositoryMapper>();

            return services;
        }

        private static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPizzaRepository, PizzaRepository>();

            return services;
        }
    }
}
