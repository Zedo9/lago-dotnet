using System;
using System.Text.Json.Serialization;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class CreateOrUpdateCouponInput
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("amount_cents")]
        public int AmountCents { get; set; }

        [JsonPropertyName("amount_currency")]
        public string AmountCurrency { get; set; }

        [JsonPropertyName("percentage_rate")]
        public decimal PercentageRate { get; set; }

        [JsonPropertyName("coupon_type")]
        public CouponType CouponType { get; set; }

        [JsonPropertyName("reusable")]
        public bool Reusable { get; set; }

        [JsonPropertyName("limited_plans")]
        public bool LimitedPlans { get; set; }

        [JsonPropertyName("frequency")]
        public Frequency Frequency { get; set; }

        [JsonPropertyName("frequency_duration")]
        public int FrequencyDuration { get; set; }

        [JsonPropertyName("plan_codes")]
        public string[] PlanCodes { get; set; }

        [JsonPropertyName("expiration")]
        public Expiration Expiration { get; set; }

        [JsonPropertyName("expiration_date")]
        public DateTime ExpirationDate { get; set; }
    }

    internal class CreateOrUpdateCouponInputWrapper
    {
        internal CreateOrUpdateCouponInputWrapper(CreateOrUpdateCouponInput createOrUpdateCouponInput)
        {
            Coupon = createOrUpdateCouponInput;
        }

        [JsonPropertyName("coupon")]
        internal CreateOrUpdateCouponInput Coupon { get; set; }
    }
}