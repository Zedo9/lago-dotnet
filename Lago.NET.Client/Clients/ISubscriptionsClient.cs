using System.Threading;
using System.Threading.Tasks;

using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.DTOs.ListResults;
using Lago.NET.Client.Models;

using Refit;

namespace Lago.NET.Client.Clients
{
    public interface ISubscriptionsClient : IFluentInterface
    {
        #region Public
        async Task<Subscription> CreateAsync(
                    CreateSubscriptionInput createSubscriptionInput,
                    CancellationToken cancellationToken = default)
        {
            var result = await CreateAsyncInternal(
                new CreateSubscriptionInputWrapper(createSubscriptionInput),
                cancellationToken);

            return result?.Subscription;
        }

        async Task<Subscription> TerminateAsync(
            string subscriptionExternalId,
            CancellationToken cancellationToken = default)
        {
            var result = await DeleteAsyncInternal(subscriptionExternalId, cancellationToken);

            return result?.Subscription;
        }

        async Task<Subscription> UpdateAsync(
            string subscriptionExternalId,
            UpdateSubscriptionInput updateSubscriptionInput,
            CancellationToken cancellationToken = default)
        {
            var result = await UpdateAsyncInternal(
                subscriptionExternalId,
                new UpdateSubscriptionInputWrapper(updateSubscriptionInput),
                cancellationToken);

            return result?.Subscription;
        }

        [Get("/subscriptions")]
        Task<SubscriptionsResult> FindAllCustomerSubscriptionsAsync(
            [AliasAs("external_customer_id")] string externalCustomerId,
            CancellationToken cancellationToken = default);
        #endregion

        #region Internal
        [Post("/subscriptions")]
        internal Task<SubscriptionWrapper> CreateAsyncInternal(
            [Body] CreateSubscriptionInputWrapper resource,
            CancellationToken cancellationToken);

        [Put("/subscriptions/{subscriptionExternalId}")]
        internal Task<SubscriptionWrapper> UpdateAsyncInternal(
            string subscriptionExternalId,
            [Body] UpdateSubscriptionInputWrapper resource,
            CancellationToken cancellationToken);

        [Delete("/subscriptions/{subscriptionExternalId}")]
        internal Task<SubscriptionWrapper> DeleteAsyncInternal(
            string subscriptionExternalId,
            CancellationToken cancellationToken);
        #endregion
    }
}