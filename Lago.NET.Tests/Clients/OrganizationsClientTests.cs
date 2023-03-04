namespace Lago.NET.Tests.Clients
{
    public class OrganizationsClientTests
    {
        private readonly MockHttpMessageHandler _mockHandler;
        private readonly ILagoClient _sut;
        private readonly string _resourceName = "organization";

        public OrganizationsClientTests()
        {
            _mockHandler = new MockHttpMessageHandler();
            _sut = LagoClientFactory.Create("apiKey", "https://api.getlago.com", _mockHandler.ToHttpClient());
        }

        [Fact]
        public async Task Valid_Update_RequestAsync()
        {
            _mockHandler
               .When(HttpMethod.Put, "https://api.getlago.com/api/v1/organizations")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetJson(_resourceName));

            var updateOrganizationInput = new UpdateOrganizationInput()
            {
                Name = "Hooli",
            };

            var organization = await _sut.Organizations.UpdateAsync(updateOrganizationInput);

            Assert.Equal("Hooli", organization.Name);
            Assert.Equal("https://test-example.example", organization.WebhookUrl);
            Assert.Equal("city125", organization.City);
            Assert.Null(organization.BillingConfiguration.InvoiceFooter);
            Assert.Equal(3, organization.BillingConfiguration.InvoiceGracePeriod);
            Assert.Equal(15.0, organization.BillingConfiguration.VatRate);
        }
    }
}