using System.Threading;
using System.Threading.Tasks;

using Lago.NET.Client.DTOs.Filters;
using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.DTOs.ListResults;
using Lago.NET.Client.Models;

using Refit;

namespace Lago.NET.Client.Clients
{
    public interface IAddOnsClient : IFluentInterface
    {
        async Task<AddOn> CreateAsync(
                    CreateAddOnInput createAddonInput,
                    CancellationToken cancellationToken = default)
        {
            var result = await CreateAsyncInternal(
                new CreateAddOnInputWrapper(createAddonInput),
                cancellationToken);

            return result?.AddOn;
        }

        async Task<AddOn> UpdateAsync(
            string code,
            UpdateAddOnInput updateAddOnInput,
            CancellationToken cancellationToken = default)
        {
            var result = await UpdateAsyncInternal(
                code,
                new UpdateAddOnInputWrapper(updateAddOnInput),
                cancellationToken);

            return result?.AddOn;
        }

        async Task<AddOn> DestroyAsync(
            string code,
            CancellationToken cancellationToken = default)
        {
            var result = await DeleteAsyncInternal(code, cancellationToken);

            return result?.AddOn;
        }

        async Task<AddOn> FindOneAsync(
            string code,
            CancellationToken cancellationToken = default)
        {
            var result = await FindOneAsyncInternal(code, cancellationToken);

            return result?.AddOn;
        }

        async Task<AppliedAddOn> ApplyToCustomerAsync(
            ApplyAddOnInput createAppliedAddOnInput,
            CancellationToken cancellationToken = default)
        {
            var result = await ApplyToCustomerAsyncInternal(
                new CreateAppliedAddOnInputWrapper(createAppliedAddOnInput),
                cancellationToken);

            return result?.AppliedAddOn;
        }

        [Get("/add_ons")]
        Task<AddOnsResult> FindAllAsync(
             [Query] PageFilter pageFilter = null,
             CancellationToken cancellationToken = default);

        #region Internal
        [Post("/add_ons")]
        internal Task<AddOnWrapper> CreateAsyncInternal(
            [Body] CreateAddOnInputWrapper createAddOnInputWrapper,
            CancellationToken cancellationToken);

        [Post("/applied_add_ons")]
        internal Task<AppliedAddOnWrapper> ApplyToCustomerAsyncInternal(
            [Body] CreateAppliedAddOnInputWrapper createAppliedAddOnInputWrapper,
            CancellationToken cancellationToken);

        [Put("/add_ons/{code}")]
        internal Task<AddOnWrapper> UpdateAsyncInternal(
            string code,
            [Body] UpdateAddOnInputWrapper updateAddOnInputWrapper,
            CancellationToken cancellationToken);

        [Delete("/add_ons/{code}")]
        internal Task<AddOnWrapper> DeleteAsyncInternal(
            string code,
            CancellationToken cancellationToken);

        [Get("/add_ons/{code}")]
        internal Task<AddOnWrapper> FindOneAsyncInternal(
            string code,
            CancellationToken cancellationToken);
        #endregion
    }
}