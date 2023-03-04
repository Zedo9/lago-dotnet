namespace Lago.NET.Tests.Clients
{
    public class AddOnsClientTests
    {
        private readonly MockHttpMessageHandler _mockHandler;
        private readonly ILagoClient _sut;
        private readonly string _resourceName = "add_on";

        public AddOnsClientTests()
        {
            _mockHandler = new MockHttpMessageHandler();
            _sut = LagoClientFactory.Create("apiKey", "https://api.getlago.com", _mockHandler.ToHttpClient());
        }

        [Fact]
        public async Task Valid_Create_Request()
        {
            _mockHandler
               .When(HttpMethod.Post, "https://api.getlago.com/api/v1/add_ons")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetJson(_resourceName));

            var input = new CreateAddOnInput(
                "add_on_name",
                "add_on_code",
                5000,
                "USD",
                "desc");

            var result = await _sut.AddOns.CreateAsync(input);

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac129b", result.LagoId);
            Assert.Equal(5000, result.AmountCents);
            Assert.Equal("USD", result.AmountCurrency);
            Assert.Equal("desc", result.Description);
            Assert.Equal("add_on_name", result.Name);
            Assert.Equal("add_on_code", result.Code);
        }

        [Fact]
        public async Task Valid_Update_Request()
        {
            _mockHandler
               .When(HttpMethod.Put, "https://api.getlago.com/api/v1/add_ons/add_on_code")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetJson(_resourceName));

            var input = new UpdateAddOnInput()
            {
                Name = "add_on_name"
            };

            var result = await _sut.AddOns.UpdateAsync("add_on_code", input);

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac129b", result.LagoId);
            Assert.Equal(5000, result.AmountCents);
            Assert.Equal("USD", result.AmountCurrency);
            Assert.Equal("desc", result.Description);
            Assert.Equal("add_on_name", result.Name);
            Assert.Equal("add_on_code", result.Code);
        }

        [Fact]
        public async Task Valid_Delete_Request()
        {
            _mockHandler
               .When(HttpMethod.Delete, "https://api.getlago.com/api/v1/add_ons/add_on_code")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetJson(_resourceName));

            var result = await _sut.AddOns.DestroyAsync("add_on_code");

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac129b", result.LagoId);
            Assert.Equal(5000, result.AmountCents);
            Assert.Equal("USD", result.AmountCurrency);
            Assert.Equal("desc", result.Description);
            Assert.Equal("add_on_name", result.Name);
            Assert.Equal("add_on_code", result.Code);
        }

        [Fact]
        public async Task Valid_FindAll_Request()
        {
            _mockHandler
               .When(HttpMethod.Get, "https://api.getlago.com/api/v1/add_ons")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetIndexJson(_resourceName));

            var result = await _sut.AddOns.FindAllAsync();
            var addOns = result.AddOns.ToList();

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac1111", addOns[0].LagoId);
            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac1222", addOns[1].LagoId);
        }

        [Fact]
        public async Task Valid_FindAll_WithPageFilter_Request()
        {
            _mockHandler
               .When(HttpMethod.Get, "https://api.getlago.com/api/v1/add_ons?per_page=2&page=1")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetIndexJson(_resourceName));

            var result = await _sut.AddOns.FindAllAsync(new PageFilter(2, 1));
            var addOns = result.AddOns.ToList();

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac1111", addOns[0].LagoId);
            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac1222", addOns[1].LagoId);
        }

        [Fact]
        public async Task Valid_FindOne_Request()
        {
            _mockHandler
               .When(HttpMethod.Get, "https://api.getlago.com/api/v1/add_ons/b7ab2926-1de8-4428-9bcd-779314ac129b")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetJson(_resourceName));

            var result = await _sut.AddOns.FindOneAsync("b7ab2926-1de8-4428-9bcd-779314ac129b");

            Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac129b", result.LagoId);
        }
    }
}