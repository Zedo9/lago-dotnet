using System.Text.Json.Serialization;

using Lago.NET.Client.DTOs.Inputs;

namespace Lago.NET.Client.Models
{
    public class Customer : CustomerInput
    {
        /// <summary>
        /// Unique identifer of the customer in Lago application.
        /// </summary>
        [JsonPropertyName("lago_id")]
        public string LagoId { get; set; }

        /// <summary>
        /// Sequential id of the customer scoped on the organization.
        /// </summary>
        [JsonPropertyName("sequential_id")]
        public string SequentialId { get; set; }

        /// <summary>
        /// Slug of the customer based on the Organization name, id and customer sequential_id.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
    }

    public class CustomerWrapper
    {
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }
    }
}