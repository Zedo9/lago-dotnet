using System;
using System.Net.Http;

using Lago.NET.Client.Clients;
using Lago.NET.Client.Constants;

using Microsoft.Extensions.DependencyInjection;

using Refit;

namespace Lago.NET.Client.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLagoClient(
                this IServiceCollection services,
                Action<HttpClient> configureClient,
                string apiKey,
                string apiHost = Defaults.DefaultHost)
        {
            var baseEndpoint = new Uri($"{apiHost}{Defaults.DefaultPath}");

            services.AddRefitClient<IAddOnsClient>(LagoClientFactory.DefaultRefitSettings)
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = baseEndpoint;
                    c.AddHeaders(apiKey);
                    configureClient(c);
                });

            services.AddRefitClient<IBillableMetricsClient>(LagoClientFactory.DefaultRefitSettings)
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = baseEndpoint;
                    c.AddHeaders(apiKey);
                    configureClient(c);
                });

            services.AddRefitClient<ICouponsClient>(LagoClientFactory.DefaultRefitSettings)
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = baseEndpoint;
                    c.AddHeaders(apiKey);
                    configureClient(c);
                });

            services.AddRefitClient<ICustomersClient>(LagoClientFactory.DefaultRefitSettings)
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = baseEndpoint;
                    c.AddHeaders(apiKey);
                    configureClient(c);
                });

            services.AddRefitClient<IOrganizationsClient>(LagoClientFactory.DefaultRefitSettings)
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = baseEndpoint;
                    c.AddHeaders(apiKey);
                    configureClient(c);
                });

            services.AddRefitClient<ISubscriptionsClient>(LagoClientFactory.DefaultRefitSettings)
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = baseEndpoint;
                    c.AddHeaders(apiKey);
                    configureClient(c);
                });

            services.AddRefitClient<IWalletsClient>(LagoClientFactory.DefaultRefitSettings)
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = baseEndpoint;
                    c.AddHeaders(apiKey);
                    configureClient(c);
                });

            services.AddTransient<ILagoClient, LagoClient>();

            return services;
        }
    }
}