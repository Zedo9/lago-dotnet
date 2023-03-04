using System;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class AppliedCoupon
    {
        public string LagoId { get; set; }

        public string LagoCouponId { get; set; }

        public string CouponCode { get; set; }

        public CouponStatus Status { get; set; }

        public string ExternalCustomerId { get; set; }

        public string LagoCustomerId { get; set; }

        public int AmountCents { get; set; }

        public int? AmountCentsRemaining { get; set; }

        public string AmountCurrency { get; set; }

        public DateTime ExpirationDate { get; set; }

        public double? PercentageRate { get; set; }

        public Frequency Frequency { get; set; }

        public int? FrequencyDuration { get; set; }

        public int? FrequencyDurationRemaining { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime TerminatedAt { get; set; }
    }

    internal class AppliedCouponWrapper
    {
        public AppliedCoupon AppliedCoupon { get; set; }
    }
}