using System;
using System.Text.Json.Serialization;

using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class Wallet : CreateWalletInput
    {
        /// <summary>
        /// Unique identifier of the Coupon in Lago application.
        /// </summary>
        [JsonPropertyName("lago_id")]
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Coupon creation.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("lago_customer_id")]
        public string LagoCustomerId { get; set; }

        [JsonPropertyName("status")]
        public WalletStatus Status { get; set; }

        [JsonPropertyName("credits_balance")]
        public string CreditsBalance { get; set; }

        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        [JsonPropertyName("consumed_credits")]
        public string ConsumedCredits { get; set; }

        [JsonPropertyName("last_balance_sync_at")]
        public DateTime LastBalanceSyncAt { get; set; }

        [JsonPropertyName("last_consumed_credit_at")]
        public DateTime LastConsumedCreditAt { get; set; }

        [JsonPropertyName("terminated_at")]
        public DateTime TerminatedAt { get; set; }
    }

    public class WalletWrapper
    {
        [JsonPropertyName("wallet")]
        public Wallet Wallet { get; set; }
    }
}