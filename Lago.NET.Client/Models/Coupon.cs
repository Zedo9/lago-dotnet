using System;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class Coupon
    {
        /// <summary>
        /// Unique identifier of the Coupon in Lago application.
        /// </summary>
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Coupon creation.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int? AmountCents { get; set; }

        public string AmountCurrency { get; set; }

        public double? PercentageRate { get; set; }

        public CouponType CouponType { get; set; }

        public bool? Reusable { get; set; }

        public bool? LimitedPlans { get; set; }

        public Frequency Frequency { get; set; }

        public int? FrequencyDuration { get; set; }

        public string[] PlanCodes { get; set; }

        public Expiration Expiration { get; set; }

        public DateTime ExpirationAt { get; set; }
    }

    internal class CouponWrapper
    {
        public Coupon Coupon { get; set; }
    }
}