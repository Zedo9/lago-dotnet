namespace Lago.NET.Client.DTOs.Inputs
{
    public class ApplyCouponInput
    {
        public ApplyCouponInput(string externalCustomerId, string couponCode)
        {
            ExternalCustomerId = externalCustomerId;
            CouponCode = couponCode;
        }

        public string ExternalCustomerId { get; set; }

        public string CouponCode { get; set; }

        public int? AmountCents { get; set; }

        public string AmountCurrency { get; set; }

        public double? PercentageRate { get; set; }

        public string Frequency { get; set; }

        public int? FrequencyDuration { get; set; }
    }

    internal class ApplyCouponInputWrapper
    {
        public ApplyCouponInputWrapper(ApplyCouponInput applyCouponInput)
        {
            AppliedCoupon = applyCouponInput;
        }

        public ApplyCouponInput AppliedCoupon { get; set; }
    }
}