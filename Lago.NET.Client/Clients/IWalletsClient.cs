using System.Threading;
using System.Threading.Tasks;

using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.DTOs.ListResults;
using Lago.NET.Client.DTOs.Filters;
using Lago.NET.Client.Models;

using Refit;

namespace Lago.NET.Client.Clients
{
    public interface IWalletsClient : IFluentInterface
    {
        async Task<Wallet> CreateAsync(
                            CreateWalletInput createWalletInput,
                            CancellationToken cancellationToken = default)
        {
            var result = await CreateAsyncInternal(
                new CreateWalletInputWrapper(createWalletInput),
                cancellationToken);

            return result?.Wallet;
        }

        async Task<Wallet> TerminateAsync(
            string walletId,
            CancellationToken cancellationToken = default)
        {
            var result = await DeleteAsyncInternal(walletId, cancellationToken);

            return result?.Wallet;
        }

        async Task<Wallet> UpdateAsync(
            string walletId,
            UpdateWalletInput updateWalletInput,
            CancellationToken cancellationToken = default)
        {
            var result = await UpdateAsyncInternal(
                walletId,
                new UpdateWalletInputWrapper(updateWalletInput),
                cancellationToken);

            return result?.Wallet;
        }

        async Task<Wallet> FindOneAsync(
            string walletId,
            CancellationToken cancellationToken = default)
        {
            var result = await FindOneAsyncInternal(walletId, cancellationToken);

            return result?.Wallet;
        }

        [Get("/wallets")]
        Task<WalletsResult> FindAllAsync(
            [Query] PageFilter pageFilter = null,
            [AliasAs("external_customer_id")] string externalCustomerId = null,
            CancellationToken cancellationToken = default
        );

        async Task<WalletTransaction> CreateTransactionAsync(
            CreateWalletTransactionInput createWalletTransactionInput,
            CancellationToken cancellationToken = default)
        {
            var result = await CreateTransactionAsyncInternal(
                new CreateWalletTransactionInputWrapper(createWalletTransactionInput),
                cancellationToken);

            return result?.WalletTransaction;
        }

        [Get("/wallets/{walletId}/wallet_transactions")]
        Task<WalletTransactionsResult> FindAllTransactionsAsync(
            string walletId,
            [Query] WalletTransactionsFilter walletTransactionsFilter = null,
            CancellationToken cancellationToken = default
        );

        #region Internal
        [Post("/wallets")]
        internal Task<WalletWrapper> CreateAsyncInternal(
            [Body] CreateWalletInputWrapper createWalletInputWrapper,
            CancellationToken cancellationToken);

        [Put("/wallets/{walletId}")]
        internal Task<WalletWrapper> UpdateAsyncInternal(
            string walletId,
            [Body] UpdateWalletInputWrapper billableMetricInputWrapper,
            CancellationToken cancellationToken);

        [Delete("/wallets/{walletId}")]
        internal Task<WalletWrapper> DeleteAsyncInternal(
            string walletId,
            CancellationToken cancellationToken);

        [Get("/wallets/{walletId}")]
        internal Task<WalletWrapper> FindOneAsyncInternal(
            string walletId,
            CancellationToken cancellationToken);

        [Post("/wallet_transactions")]
        internal Task<WalletTransactionWrapper> CreateTransactionAsyncInternal(
            [Body] CreateWalletTransactionInputWrapper createWalletInputWrapper,
            CancellationToken cancellationToken);
        #endregion
    }
}