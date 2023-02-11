using System;
using System.Text.Json.Serialization;

namespace Lago.NET.Client.Models
{
    public class Group
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

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}