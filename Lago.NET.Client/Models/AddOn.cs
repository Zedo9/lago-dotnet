using System;
using System.Text.Json.Serialization;

namespace Lago.NET.Client.Models
{
    public class AddOn
    {
        /// <summary>
        /// Unique identifier of the Add-on in Lago application.
        /// </summary>
        [JsonPropertyName("lago_id")]
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Addon creation.
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

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}