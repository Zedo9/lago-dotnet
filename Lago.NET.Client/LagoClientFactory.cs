using System;
using System.Net.Http;

using Lago.NET.Client.Clients;
using Lago.NET.Client.Constants;
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
            httpClient.BaseAddress = new Uri($"{apiHost}{Defaults.DefaultPath}");
            httpClient.AddHeaders(apiKey);

            var billableMetricsClient = RestService.For<IBillableMetricsClient>(httpClient, DefaultRefitSettings);
            var customersClient = RestService.For<ICustomersClient>(httpClient, DefaultRefitSettings);
            var walletsClient = RestService.For<IWalletsClient>(httpClient, DefaultRefitSettings);
            var organizationsClient = RestService.For<IOrganizationsClient>(httpClient, DefaultRefitSettings);
            var subscriptionsClient = RestService.For<ISubscriptionsClient>(httpClient, DefaultRefitSettings);
            var addOnsClient = RestService.For<IAddOnsClient>(httpClient, DefaultRefitSettings);
            var couponsClient = RestService.For<ICouponsClient>(httpClient, DefaultRefitSettings);

            return new LagoClient(
                billableMetricsClient,
                customersClient,
                walletsClient,
                subscriptionsClient,
                organizationsClient,
                addOnsClient,
                couponsClient);
        }

        public static ILagoClient Create(
            string apiKey,
            string apiHost = Defaults.DefaultBaseUrl)
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