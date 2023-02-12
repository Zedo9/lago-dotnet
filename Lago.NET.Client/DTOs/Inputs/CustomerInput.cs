using System.Text.Json.Serialization;

using Lago.NET.Client.Models;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class CustomerInput
    {
        /// <summary>
        /// Unique identifer of the customer in your application.
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// First line of the billing address.
        /// </summary>
        [JsonPropertyName("address_line1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Second line of the billing address.
        /// </summary>
        [JsonPropertyName("address_line2")]
        public object AddressLine2 { get; set; }

        /// <summary>
        /// City of the customer's billing address.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// Country code of the customer's billing address.
        /// </summary>
        /// <remarks> 
        /// ISO 3166 alpha 2 Country code. 
        /// </remarks>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Currency of the customer.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Email of the customer.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Legal company name of the customer.
        /// </summary>
        [JsonPropertyName("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// Legal company number of the customer.
        /// </summary>
        [JsonPropertyName("legal_number")]
        public string LegalNumber { get; set; }

        /// <summary>
        /// Logo URL of the customer.
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Full name of the customer.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Phone number of the customer.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// State of the customer's billing address.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Custom URL of the customer.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Zipcode of the customer's billing address.
        /// </summary>
        [JsonPropertyName("zipcode")]
        public string Zipcode { get; set; }

        /// <summary>
        /// Billing configuration of the customer.
        /// </summary>
        [JsonPropertyName("billing_configuration")]
        public CustomerBillingConfiguration BillingConfiguration { get; set; }
    }

    internal class CustomerInputWrapper
    {
        public CustomerInputWrapper(CustomerInput customerInput)
        {
            Customer = customerInput;
        }

        [JsonPropertyName("customer")]
        public CustomerInput Customer { get; set; }
    }
}