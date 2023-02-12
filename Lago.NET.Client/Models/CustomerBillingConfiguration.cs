using System.Text.Json.Serialization;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class CustomerBillingConfiguration
    {
        /// <summary>
        /// Payment provider used to bill the customer. .
        /// </summary>
        [JsonPropertyName("payment_provider")]
        public PaymentProvider PaymentProvider { get; set; }

        /// <summary>
        /// Customer ID on the payment provider.
        /// </summary>
        [JsonPropertyName("provider_customer_id")]
        public string ProviderCustomerId { get; set; }

        /// <summary>
        /// Custom VAT rate applied to the customer.
        /// </summary>
        [JsonPropertyName("vat_rate")]
        public decimal VatRate { get; set; }

        /// <summary>
        /// Field that determines whether to create customer in payment provider or not..
        /// </summary>
        [JsonPropertyName("sync_with_provider")]
        public bool SyncWithProvider { get; set; }
    }
}