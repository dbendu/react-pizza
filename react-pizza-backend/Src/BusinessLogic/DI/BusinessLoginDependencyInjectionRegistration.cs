using BusinessLogic.Services.Pizza;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.DI
{
    public static class BusinessLoginDependencyInjectionRegistration
    {
        public static IServiceCollection RegisterBusinessLogic(this IServiceCollection services)
        {
            services
                .RegisterServices();

            return services;
        }

        private static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPizzaService, PizzaService>();

            return services;
        }
    }
}
