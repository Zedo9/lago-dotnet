using System;
using System.Text.Json.Serialization;

namespace Lago.NET.Client.Models
{
    public class Organization
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("webhook_url")]
        public string WebhookUrl { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("address_line1")]
        public string AddressLine1 { get; set; }

        [JsonPropertyName("address_line2")]
        public string AddressLine2 { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("zipcode")]
        public string Zipcode { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("legal_name")]
        public string LegalName { get; set; }

        [JsonPropertyName("legal_number")]
        public string LegalNumber { get; set; }

        [JsonPropertyName("timezone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("billing_configuration")]
        public OrgBillingConfiguration BillingConfiguration { get; set; }
    }

    internal class OrganizationWrapper
    {
        [JsonPropertyName("organization")]
        public Organization Organization { get; set; }
    }
}