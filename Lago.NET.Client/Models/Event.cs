using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Lago.NET.Client.Models
{
    public class Event
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

        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        [JsonPropertyName("lago_customer_id")]
        public string LagoCustomerId { get; set; }

        [JsonPropertyName("external_customer_id")]
        public string ExternalCustomerId { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("properties")]
        public Dictionary<string, string> Properties { get; set; }

        [JsonPropertyName("lago_subscription_id")]
        public string LagoSubscriptionId { get; set; }

        [JsonPropertyName("external_subscription_id")]
        public string ExternalSubscriptionId { get; set; }
    }
}