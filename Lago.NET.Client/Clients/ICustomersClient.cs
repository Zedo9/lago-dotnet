using System.Threading;
using System.Threading.Tasks;

using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.DTOs.ListResults;
using Lago.NET.Client.DTOs.Filters;
using Lago.NET.Client.Models;

using Refit;

namespace Lago.NET.Client.Clients
{
    public interface ICustomersClient : IFluentInterface
    {
        async Task<Customer> CreateOrUpdateAsync(
            CreateOrUpdateCustomerInput customerInput,
            CancellationToken cancellationToken = default)
        {
            var result = await CreateOrUpdateAsyncInternal(
                    new CreateOrUpdateCustomerInputWrapper(customerInput),
                    cancellationToken);

            return result?.Customer;
        }

        async Task<Customer> FindOneAsync(
            string customerExternalId,
            CancellationToken cancellationToken = default)
        {
            var result = await FindOneAsyncInternal(customerExternalId, cancellationToken);

            return result?.Customer;
        }

        async Task<Customer> DestroyAsync(
            string customerExternalId,
            CancellationToken cancellationToken = default)
        {
            var result = await DestroyAsyncInternal(customerExternalId, cancellationToken);

            return result?.Customer;
        }

        [Get("/customers")]
        Task<BillableMetricsResult> FindAllAsync(
             [Query] PageFilter pageFilter = null,
             CancellationToken cancellationToken = default);

        #region Internal
        [Post("/customers")]
        internal Task<CustomerWrapper> CreateOrUpdateAsyncInternal(
            [Body] CreateOrUpdateCustomerInputWrapper resource,
            CancellationToken cancellationToken);

        [Get("/customers/{customerExternalId}")]
        internal Task<CustomerWrapper> FindOneAsyncInternal(
            string customerExternalId,
            CancellationToken cancellationToken);

        [Delete("/customers/{customerExternalId}")]
        internal Task<CustomerWrapper> DestroyAsyncInternal(
            string customerExternalId,
            CancellationToken cancellationToken);
        #endregion
    }
}