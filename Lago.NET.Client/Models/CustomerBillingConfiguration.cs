using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class CustomerBillingConfiguration
    {
        /// <summary>
        /// Grace period in days for the invoice 
        /// (time between the end of the period and the closing of the invoice).
        /// </summary>
        public int InvoiceGracePeriod { get; set; }

        /// <summary>
        /// Payment provider used to bill the customer. .
        /// </summary>
        public PaymentProvider PaymentProvider { get; set; }

        /// <summary>
        /// Customer ID on the payment provider.
        /// </summary>
        public string ProviderCustomerId { get; set; }

        /// <summary>
        /// Custom VAT rate applied to the customer.
        /// </summary>
        public double VatRate { get; set; }

        /// <summary>
        /// Field that determines whether to create customer in payment provider or not..
        /// </summary>
        public bool SyncWithProvider { get; set; }
    }
}