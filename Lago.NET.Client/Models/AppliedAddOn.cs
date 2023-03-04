using System;

namespace Lago.NET.Client.Models
{
    public class AppliedAddOn
    {
        public string LagoId { get; set; }

        public string LagoAddOnId { get; set; }

        public string AddOnCode { get; set; }

        public string ExternalCustomerId { get; set; }

        public string LagoCustomerId { get; set; }

        public int AmountCents { get; set; }

        public string AmountCurrency { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    internal class AppliedAddOnWrapper
    {
        public AppliedAddOn AppliedAddOn { get; set; }
    }
}