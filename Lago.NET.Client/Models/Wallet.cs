using System;

using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class Wallet : CreateWalletInput
    {
        /// <summary>
        /// Unique identifier of the Coupon in Lago application.
        /// </summary>
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Coupon creation.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        public string LagoCustomerId { get; set; }

        public WalletStatus Status { get; set; }

        public string CreditsBalance { get; set; }

        public string Balance { get; set; }

        public string ConsumedCredits { get; set; }

        public DateTime LastBalanceSyncAt { get; set; }

        public DateTime LastConsumedCreditAt { get; set; }

        public DateTime TerminatedAt { get; set; }
    }

    public class WalletWrapper
    {
        public Wallet Wallet { get; set; }
    }
}