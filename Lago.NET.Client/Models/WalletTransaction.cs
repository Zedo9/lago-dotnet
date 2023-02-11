using System;
using System.Text.Json.Serialization;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class WalletTransaction
    {
        [JsonPropertyName("lago_id")]
        public string LagoId { get; set; }

        [JsonPropertyName("lago_wallet_id")]
        public string LagoWalletId { get; set; }

        [JsonPropertyName("status")]
        public WalletTransactionStatus Status { get; set; }

        [JsonPropertyName("transaction_type")]
        public WalletTransactionType TransactionType { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("credit_amount")]
        public string CreditAmount { get; set; }

        [JsonPropertyName("settled_at")]
        public DateTime SettledAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public class WalletTransactionWrapper
    {
        [JsonPropertyName("wallet_transaction")]
        public WalletTransaction WalletTransaction { get; set; }
    }
}