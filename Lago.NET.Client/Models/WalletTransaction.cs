using System;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class WalletTransaction
    {
        public string LagoId { get; set; }

        public string LagoWalletId { get; set; }

        public WalletTransactionStatus Status { get; set; }

        public WalletTransactionType TransactionType { get; set; }

        public string Amount { get; set; }

        public string CreditAmount { get; set; }

        public DateTime SettledAt { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public class WalletTransactionWrapper
    {
        public WalletTransaction WalletTransaction { get; set; }
    }
}