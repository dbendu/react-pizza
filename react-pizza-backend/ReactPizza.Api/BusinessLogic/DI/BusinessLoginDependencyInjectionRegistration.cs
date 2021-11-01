using BusinessLogic.Services.Pizza;
using BusinessLogic.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.DI
{
    public static class BusinessLoginDependencyInjectionRegistration
    {
        public static IServiceCollection RegisterBusinessLogic(this IServiceCollection services)
        {
            services
                .RegisterSettings()
                .RegisterServices();

            return services;
        }

        private static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPizzaService, PizzaService>();

            return services;
        }

        private static IServiceCollection RegisterSettings(this IServiceCollection services)
        {
            services.AddOptions<MediaProviderSettings>()
                .BindConfiguration(nameof(MediaProviderSettings));

            return services;
        }
    }
}
