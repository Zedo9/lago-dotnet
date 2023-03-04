using Lago.NET.Client.Enums;

using Refit;

namespace Lago.NET.Client.DTOs.Filters
{
    public class WalletTransactionsFilter : PageFilter
    {
        [AliasAs("status")]
        public WalletTransactionStatus? Status { get; set; }

        [AliasAs("transaction_type")]
        public WalletTransactionType? Type { get; set; }

        public WalletTransactionsFilter(
            int perPage,
            int page,
            WalletTransactionStatus? walletTransactionStatus = null,
            WalletTransactionType? walletTransactionType = null
            ) : base(perPage, page)
        {
            Status = walletTransactionStatus;
            Type = walletTransactionType;
        }

        public WalletTransactionsFilter(
           WalletTransactionStatus? walletTransactionStatus = null,
           WalletTransactionType? walletTransactionType = null)
        {
            Status = walletTransactionStatus;
            Type = walletTransactionType;
        }
    }
}