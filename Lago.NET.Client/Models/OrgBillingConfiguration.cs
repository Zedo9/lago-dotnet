namespace Lago.NET.Client.Models
{
    public class OrgBillingConfiguration
    {
        public string InvoiceFooter { get; set; }

        public int? InvoiceGracePeriod { get; set; }

        public double? VatRate { get; set; }
    }
}