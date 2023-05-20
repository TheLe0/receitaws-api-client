using Receitaws.API.Client.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Receitaws.API.Client.Infrastructure;

namespace Receitaws.API.Client.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCreateApiClient(this IServiceCollection services)
        {
            services.AddTransient<IReceitawsApiHttpClient, ReceitawsApiHttpClient>();

            services.AddTransient<ICreateApiClient>(x =>
                new CreateApiClient(x.GetRequiredService<IReceitawsApiHttpClient>()));

            return services;
        }

        public static IServiceCollection AddCreateApiClient(this IServiceCollection services, string baseUrl)
        {
            services.AddTransient<IReceitawsApiHttpClient>(_ =>
                new ReceitawsApiHttpClient(baseUrl));

            services.AddTransient<ICreateApiClient>(x =>
                new CreateApiClient(x.GetRequiredService<IReceitawsApiHttpClient>()));

            return services;
        }

        public static IServiceCollection AddCreateApiClient(this IServiceCollection services, ReceitawsApiClientConfiguration configs)
        {
            services.AddTransient<IReceitawsApiHttpClient>(_ =>
                new ReceitawsApiHttpClient(configs));

            services.AddTransient<ICreateApiClient>(x =>
                new CreateApiClient(x.GetRequiredService<IReceitawsApiHttpClient>()));

            return services;
        }
    }
}
