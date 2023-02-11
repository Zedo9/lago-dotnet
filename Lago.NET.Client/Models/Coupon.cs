using System;
using System.Text.Json.Serialization;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class Coupon
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

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("amount_cents")]
        public int AmountCents { get; set; }

        [JsonPropertyName("amount_currency")]
        public string AmountCurrency { get; set; }

        [JsonPropertyName("percentage_rate")]
        public double PercentageRate { get; set; }

        [JsonPropertyName("coupon_type")]
        public CouponType CouponType { get; set; }

        [JsonPropertyName("reusable")]
        public bool Reusable { get; set; }

        [JsonPropertyName("frequency")]
        public Frequency Frequency { get; set; }

        [JsonPropertyName("frequency_duration")]
        public int FrequencyDuration { get; set; }

        [JsonPropertyName("expiration")]
        public Expiration Expiration { get; set; }

        [JsonPropertyName("expiration_date")]
        public DateTime ExpirationDate { get; set; }
    }
}