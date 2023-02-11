using System.Threading;
using System.Threading.Tasks;

using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.Models;

using Refit;

namespace Lago.NET.Client.Clients
{
    public interface IWalletTransactionsClient : IFluentInterface
    {
        async Task<WalletTransaction> CreateAsync(
            CreateWalletTransactionInput createWalletTransactionInput,
            CancellationToken cancellationToken = default)
        {
            var result = await CreateAsyncInternal(
                new CreateWalletTransactionInputWrapper(createWalletTransactionInput), cancellationToken);

            return result?.WalletTransaction;
        }

        #region Internal
        [Post("/wallet_transactions")]
        internal Task<WalletTransactionWrapper> CreateAsyncInternal(
            [Body] CreateWalletTransactionInputWrapper createWalletInputWrapper,
            CancellationToken cancellationToken);
        #endregion
    }
}