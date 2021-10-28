using Microsoft.Extensions.DependencyInjection;
using ReactPizza.Api.Controllers.Pizza.Mappers;

namespace ReactPizza.Api.DI
{
    public static class ApiDependencyInjectionRegistration
    {
        public static IServiceCollection RegisterApi(this IServiceCollection services)
        {
            services
                .RegisterRequestMappers()
                .RegisterResponseMappers();

            return services;
        }

        private static IServiceCollection RegisterRequestMappers(this IServiceCollection services)
        {
            services.AddScoped<IPizzaControllerRequestsMapper, PizzaControllerRequestsMapper>();

            return services;
        }

        private static IServiceCollection RegisterResponseMappers(this IServiceCollection services)
        {
            services.AddScoped<IPizzaControllerResponsesMapper, PizzaControllerResponsesMapper>();

            return services;
        }
    }
}
