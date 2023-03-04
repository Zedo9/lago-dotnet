namespace Lago.NET.Client.Models
{
    public class Customer
    {
        /// <summary>
        /// Unique identifer of the customer in Lago application.
        /// </summary>
        public string LagoId { get; set; }

        /// <summary>
        /// Sequential id of the customer scoped on the organization.
        /// </summary>
        public string SequentialId { get; set; }

        /// <summary>
        /// Slug of the customer based on the Organization name, id and customer sequential_id.
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Unique identifer of the customer in your application.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// First line of the billing address.
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Second line of the billing address.
        /// </summary>
        public object AddressLine2 { get; set; }

        /// <summary>
        /// City of the customer's billing address.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Country code of the customer's billing address.
        /// </summary>
        /// <remarks> 
        /// ISO 3166 alpha 2 Country code. 
        /// </remarks>
        public string Country { get; set; }

        /// <summary>
        /// Currency of the customer.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Email of the customer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Legal company name of the customer.
        /// </summary>
        public string LegalName { get; set; }

        /// <summary>
        /// Legal company number of the customer.
        /// </summary>
        public string LegalNumber { get; set; }

        /// <summary>
        /// Logo URL of the customer.
        /// </summary>
        public string LogoUrl { get; set; }

        /// <summary>
        /// Full name of the customer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Phone number of the customer.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// State of the customer's billing address.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Timezone of the customer.
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// Timezone applicable the customer.
        /// Value is inherited from the organization if timezone attribute is null.
        /// </summary>
        public string ApplicableTimezone { get; set; }

        /// <summary>
        /// Custom URL of the customer.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Zipcode of the customer's billing address.
        /// </summary>
        public string Zipcode { get; set; }

        /// <summary>
        /// Billing configuration of the customer.
        /// </summary>
        public CustomerBillingConfiguration BillingConfiguration { get; set; }
    }

    internal class CustomerWrapper
    {
        public Customer Customer { get; set; }
    }
}