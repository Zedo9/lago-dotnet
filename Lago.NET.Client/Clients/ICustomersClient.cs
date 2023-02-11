using System.Threading;
using System.Threading.Tasks;

using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.DTOs.ListResults;
using Lago.NET.Client.DTOs.Shared;
using Lago.NET.Client.Models;

using Refit;

namespace Lago.NET.Client.Clients
{
    public interface ICustomersClient : IFluentInterface
    {
        async Task<Customer> CreateOrUpdateAsync(
            CustomerInput customerInput,
            CancellationToken cancellationToken = default)
        {
            var result = await CreateOrUpdateAsyncInternal(
                    new CustomerInputWrapper(customerInput),
                    cancellationToken);

            return result?.Customer;
        }

        async Task<Customer> FindOneAsync(
            string code,
            CancellationToken cancellationToken = default)
        {
            var result = await FindOneAsyncInternal(code, cancellationToken);
            
            return result?.Customer;
        }

        [Get("/customers")]
        Task<BillableMetricsResult> FindAllAsync(
             [Query] PageFilter pageFilter = null,
             CancellationToken cancellationToken = default);

        #region Internal
        [Post("/customers")]
        internal Task<CustomerWrapper> CreateOrUpdateAsyncInternal(
            [Body] CustomerInputWrapper resource,
            CancellationToken cancellationToken);

        [Get("/customers/{code}")]
        internal Task<CustomerWrapper> FindOneAsyncInternal(
            string code,
            CancellationToken cancellationToken);
        #endregion
    }
}