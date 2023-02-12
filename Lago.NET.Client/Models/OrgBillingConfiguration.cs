using System.Text.Json.Serialization;

namespace Lago.NET.Client.Models
{
    public class OrgBillingConfiguration
    {
        [JsonPropertyName("invoice_footer")]
        public string InvoiceFooter { get; set; }

        [JsonPropertyName("invoice_grace_period")]
        public string InvoiceGracePeriod { get; set; }

        [JsonPropertyName("vat_rate")]
        public decimal VatRate { get; set; }
    }
}