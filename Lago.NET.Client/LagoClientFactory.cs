using System;
using System.Net.Http;

using Lago.NET.Client.Clients;
using Lago.NET.Client.Extensions;
using Lago.NET.Client.Serialization;

using Refit;

namespace Lago.NET.Client
{
    public static class LagoClientFactory
    {
        public static ILagoClient Create(
            string apiKey,
            string apiHost,
            HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri($"{apiHost}{Endpoints.ApiPath}");
            httpClient.AddHeaders(apiKey);

            var billableMetricsClient = RestService.For<IBillableMetricsClient>(httpClient, DefaultRefitSettings);
            var customersClient = RestService.For<ICustomersClient>(httpClient, DefaultRefitSettings);

            return new LagoClient(billableMetricsClient, customersClient);
        }

        public static ILagoClient Create(
            string apiKey,
            string apiHost = Endpoints.DefaultBaseUrl)
        {
            return Create(apiKey, apiHost, new HttpClient());
        }

        internal static RefitSettings DefaultRefitSettings = new RefitSettings()
        {
            ContentSerializer = SerializerSettings.DefaultSerializerSettings,
            // Wil be customized with a custom LagoException class.
            // ExceptionFactory = httpResponse => Task.FromResult<Exception>(null),
        };
    }
}