namespace Lago.NET.Tests.Clients
{
    public class CouponsClientTests
    {
        private readonly MockHttpMessageHandler _mockHandler;
        private readonly ILagoClient _sut;
        private readonly string _resourceName = "coupon";

        public CouponsClientTests()
        {
            _mockHandler = new MockHttpMessageHandler();
            _sut = LagoClientFactory.Create("apiKey", "https://api.getlago.com", _mockHandler.ToHttpClient());
        }

        [Fact]
        public async Task Valid_Create_Request()
        {
            _mockHandler
               .When(HttpMethod.Post, "https://api.getlago.com/api/v1/coupons")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetJson(_resourceName));

            var input = new CreateOrUpdateCouponInput()
            {
                Name = "coupon_name",
                Code = "coupon_code",
                AmountCents = 5000,
                AmountCurrency = "USD",
                Expiration = Expiration.NoExpiration,
                ExpirationAt = new DateTime(2022, 08, 08, 23, 59, 59),
                Frequency = Frequency.Once,
                CouponType = CouponType.FixedAmount,
                Reusable = false,
                LimitedPlans = true,
                PlanCodes = new string[] { "plan1" },
            };

            var result = await _sut.Coupons.CreateAsync(input);

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac129b", result.LagoId);
            Assert.Equal("coupon_name", result.Name);
            Assert.Equal("coupon_code", result.Code);
            Assert.Equal(5000, result.AmountCents);
            Assert.Equal("USD", result.AmountCurrency);
            Assert.Equal(Expiration.NoExpiration, result.Expiration);
            Assert.Equal(new DateTime(2022, 08, 08, 23, 59, 59), result.ExpirationAt);
            Assert.Equal(Frequency.Once, result.Frequency);
            Assert.Null(result.FrequencyDuration);
            Assert.Null(result.PercentageRate);
            Assert.Equal(CouponType.FixedAmount, result.CouponType);
            Assert.False(result.Reusable);
            Assert.True(result.LimitedPlans);
            Assert.Equal(new string[] { "plan1" }, result.PlanCodes);
        }

        [Fact]
        public async Task Valid_Update_Request()
        {
            _mockHandler
               .When(HttpMethod.Put, "https://api.getlago.com/api/v1/coupons/coupon_code")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetJson(_resourceName));

            var input = new CreateOrUpdateCouponInput()
            {
                Name = "coupon_name"
            };

            var result = await _sut.Coupons.UpdateAsync("coupon_code", input);

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac129b", result.LagoId);
            Assert.Equal("coupon_name", result.Name);
            Assert.Equal("coupon_code", result.Code);
            Assert.Equal(5000, result.AmountCents);
            Assert.Equal("USD", result.AmountCurrency);
            Assert.Equal(Expiration.NoExpiration, result.Expiration);
            Assert.Equal(new DateTime(2022, 08, 08, 23, 59, 59), result.ExpirationAt);
            Assert.Equal(Frequency.Once, result.Frequency);
            Assert.Null(result.FrequencyDuration);
            Assert.Null(result.PercentageRate);
            Assert.Equal(CouponType.FixedAmount, result.CouponType);
            Assert.False(result.Reusable);
            Assert.True(result.LimitedPlans);
            Assert.Equal(new string[] { "plan1" }, result.PlanCodes);
        }

        [Fact]
        public async Task Valid_Delete_Request()
        {
            _mockHandler
               .When(HttpMethod.Delete, "https://api.getlago.com/api/v1/coupons/coupon_code")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetJson(_resourceName));

            var result = await _sut.Coupons.DestroyAsync("coupon_code");

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac129b", result.LagoId);
            Assert.Equal("coupon_name", result.Name);
            Assert.Equal("coupon_code", result.Code);
            Assert.Equal(5000, result.AmountCents);
            Assert.Equal("USD", result.AmountCurrency);
            Assert.Equal(Expiration.NoExpiration, result.Expiration);
            Assert.Equal(new DateTime(2022, 08, 08, 23, 59, 59), result.ExpirationAt);
            Assert.Equal(Frequency.Once, result.Frequency);
            Assert.Null(result.FrequencyDuration);
            Assert.Null(result.PercentageRate);
            Assert.Equal(CouponType.FixedAmount, result.CouponType);
            Assert.False(result.Reusable);
            Assert.True(result.LimitedPlans);
            Assert.Equal(new string[] { "plan1" }, result.PlanCodes);
        }

        [Fact]
        public async Task Valid_FindAll_Request()
        {
            _mockHandler
               .When(HttpMethod.Get, "https://api.getlago.com/api/v1/coupons")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetIndexJson(_resourceName));

            var result = await _sut.Coupons.FindAllAsync();
            var addOns = result.Coupons.ToList();

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac1111", addOns[0].LagoId);
            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac1222", addOns[1].LagoId);
        }

        [Fact]
        public async Task Valid_FindAll_WithPageFilter_Request()
        {
            _mockHandler
               .When(HttpMethod.Get, "https://api.getlago.com/api/v1/coupons?per_page=2&page=1")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetIndexJson(_resourceName));

            var result = await _sut.Coupons.FindAllAsync(new PageFilter(2, 1));
            var coupons = result.Coupons.ToList();

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac1111", coupons[0].LagoId);
            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac1222", coupons[1].LagoId);
        }

        [Fact]
        public async Task Valid_FindOne_Request()
        {
            _mockHandler
               .When(HttpMethod.Get, "https://api.getlago.com/api/v1/coupons/coupon_code")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetJson(_resourceName));

            var result = await _sut.Coupons.FindOneAsync("coupon_code");

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac129b", result.LagoId);
            Assert.Equal("coupon_name", result.Name);
            Assert.Equal("coupon_code", result.Code);
            Assert.Equal(5000, result.AmountCents);
            Assert.Equal("USD", result.AmountCurrency);
            Assert.Equal(Expiration.NoExpiration, result.Expiration);
            Assert.Equal(new DateTime(2022, 08, 08, 23, 59, 59), result.ExpirationAt);
            Assert.Equal(Frequency.Once, result.Frequency);
            Assert.Null(result.FrequencyDuration);
            Assert.Null(result.PercentageRate);
            Assert.Equal(CouponType.FixedAmount, result.CouponType);
            Assert.False(result.Reusable);
            Assert.True(result.LimitedPlans);
            Assert.Equal(new string[] { "plan1" }, result.PlanCodes);
        }

        [Fact]
        public async Task Valid_FindAllApplied_WithPageFilter_Request()
        {
            _mockHandler
               .When(HttpMethod.Get, "https://api.getlago.com/api/v1/applied_coupons?per_page=2&page=1")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetIndexJson(_resourceName));

            var result = await _sut.Coupons.FindAllAppliedAsync(new PageFilter(2, 1));
            var coupons = result.Coupons.ToList();

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac1111", coupons[0].LagoId);
            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac1222", coupons[1].LagoId);
        }
    }
}