using System;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class CreateOrUpdateCouponInput
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public int? AmountCents { get; set; }

        public string AmountCurrency { get; set; }

        public double? PercentageRate { get; set; }

        public CouponType CouponType { get; set; }

        public bool? Reusable { get; set; }

        public bool? LimitedPlans { get; set; }

        public Frequency Frequency { get; set; }

        public int FrequencyDuration { get; set; }

        public string[] PlanCodes { get; set; }

        public Expiration Expiration { get; set; }

        public DateTime ExpirationAt { get; set; }
    }

    internal class CreateOrUpdateCouponInputWrapper
    {
        public CreateOrUpdateCouponInputWrapper(CreateOrUpdateCouponInput createOrUpdateCouponInput)
        {
            Coupon = createOrUpdateCouponInput;
        }

        public CreateOrUpdateCouponInput Coupon { get; set; }
    }
}