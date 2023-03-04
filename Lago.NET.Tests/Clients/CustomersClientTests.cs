using System.Net;

namespace Lago.NET.Tests.Clients
{
    public class CustomersClientTests
    {
        private readonly MockHttpMessageHandler _mockHandler;
        private readonly ILagoClient _sut;
        private readonly string _resourceName = "customer";

        public CustomersClientTests()
        {
            _mockHandler = new MockHttpMessageHandler();
            _sut = LagoClientFactory.Create("apiKey", "https://api.getlago.com", _mockHandler.ToHttpClient());
        }

        [Fact]
        public async Task Valid_CreateOrUpdate_Request()
        {
            _mockHandler
               .When(HttpMethod.Post, "https://api.getlago.com/api/v1/customers")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond(HttpStatusCode.OK, "application/json", Responses.GetJson(_resourceName));

            var input = new CreateOrUpdateCustomerInput("5eb02857-a71e-4ea2-bcf9-57d3a41bc6ba")
            {
                AddressLine1 = "5230 Penfield Ave",
                City = "Woodland Hills",
                Country = "US",
                Email = "dinesh@piedpiper.test",
                LegalName = "Coleman-Blair",
                LegalNumber = "49-008-2965",
                LogoUrl = "http://hooli.com/logo.png",
                Name = "Gavin Belson",
                Phone = "1-171-883-3711 x245",
                State = "CA",
                Url = "http://hooli.com",
                Zipcode = "91364",
                Currency = "EUR",
                Timezone = "Europe/Paris",
                BillingConfiguration = new()
                {
                    InvoiceGracePeriod = 3,
                    PaymentProvider = PaymentProvider.Stripe,
                    ProviderCustomerId = "cus_12345",
                    SyncWithProvider = true,
                    VatRate = 12.5
                }
            };

            var customer = await _sut.Customers.CreateOrUpdateAsync(input);

            Assert.Equal("99a6094e-199b-4101-896a-54e927ce7bd7", customer.LagoId);
            Assert.Equal("5230 Penfield Ave", customer.AddressLine1);
            Assert.Null(customer.AddressLine2);
            Assert.Equal("Woodland Hills", customer.City);
            Assert.Equal("US", customer.Country);
            Assert.Equal("dinesh@piedpiper.test", customer.Email);
            Assert.Equal("Coleman-Blair", customer.LegalName);
            Assert.Equal("49-008-2965", customer.LegalNumber);
            Assert.Equal("http://hooli.com/logo.png", customer.LogoUrl);
            Assert.Equal("Gavin Belson", customer.Name);
            Assert.Equal("1-171-883-3711 x245", customer.Phone);
            Assert.Equal("CA", customer.State);
            Assert.Equal("http://hooli.com", customer.Url);
            Assert.Equal("91364", customer.Zipcode);
            Assert.Equal("EUR", customer.Currency);
            Assert.Equal("Europe/Paris", customer.Timezone);
            Assert.Equal("Europe/Paris", customer.ApplicableTimezone);

            Assert.Equal(3, customer.BillingConfiguration.InvoiceGracePeriod);
            Assert.Equal(PaymentProvider.Stripe, customer.BillingConfiguration.PaymentProvider);
            Assert.Equal("cus_12345", customer.BillingConfiguration.ProviderCustomerId);
            Assert.True(customer.BillingConfiguration.SyncWithProvider);
            Assert.Equal(12.5, customer.BillingConfiguration.VatRate);
        }

        [Fact]
        public async Task Valid_Delete_Request()
        {
            _mockHandler
               .When(HttpMethod.Delete, "https://api.getlago.com/api/v1/customers/5eb02857-a71e-4ea2-bcf9-57d3a41bc6ba")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetJson(_resourceName));

            var customer = await _sut.Customers.DestroyAsync("5eb02857-a71e-4ea2-bcf9-57d3a41bc6ba");

            Assert.Equal("99a6094e-199b-4101-896a-54e927ce7bd7", customer.LagoId);
            Assert.Equal("5230 Penfield Ave", customer.AddressLine1);
            Assert.Null(customer.AddressLine2);
            Assert.Equal("Woodland Hills", customer.City);
            Assert.Equal("US", customer.Country);
            Assert.Equal("dinesh@piedpiper.test", customer.Email);
            Assert.Equal("Coleman-Blair", customer.LegalName);
            Assert.Equal("49-008-2965", customer.LegalNumber);
            Assert.Equal("http://hooli.com/logo.png", customer.LogoUrl);
            Assert.Equal("Gavin Belson", customer.Name);
            Assert.Equal("1-171-883-3711 x245", customer.Phone);
            Assert.Equal("CA", customer.State);
            Assert.Equal("http://hooli.com", customer.Url);
            Assert.Equal("91364", customer.Zipcode);
            Assert.Equal("EUR", customer.Currency);
            Assert.Equal("Europe/Paris", customer.Timezone);
            Assert.Equal("Europe/Paris", customer.ApplicableTimezone);

            Assert.Equal(3, customer.BillingConfiguration.InvoiceGracePeriod);
            Assert.Equal(PaymentProvider.Stripe, customer.BillingConfiguration.PaymentProvider);
            Assert.Equal("cus_12345", customer.BillingConfiguration.ProviderCustomerId);
            Assert.True(customer.BillingConfiguration.SyncWithProvider);
            Assert.Equal(12.5, customer.BillingConfiguration.VatRate);
        }

        [Fact]
        public Task Valid_FindAll_Request()
        {
            // TODO
            return Task.CompletedTask;
        }

        [Fact]
        public Task Valid_FindAll_WithPageFilter_Request()
        {
            // TODO
            return Task.CompletedTask;
        }

        [Fact]
        public async Task Valid_FindOne_Request()
        {
            _mockHandler
               .When(HttpMethod.Get, "https://api.getlago.com/api/v1/customers/5eb02857-a71e-4ea2-bcf9-57d3a41bc6ba")
               .WithHeaders("Authorization", "Bearer apiKey")
               .WithHeaders("Accept", "application/json")
               .Respond("application/json", Responses.GetJson(_resourceName));

            var customer = await _sut.Customers.FindOneAsync("5eb02857-a71e-4ea2-bcf9-57d3a41bc6ba");

            Assert.Equal("99a6094e-199b-4101-896a-54e927ce7bd7", customer.LagoId);
            Assert.Equal("5230 Penfield Ave", customer.AddressLine1);
            Assert.Null(customer.AddressLine2);
            Assert.Equal("Woodland Hills", customer.City);
            Assert.Equal("US", customer.Country);
            Assert.Equal("dinesh@piedpiper.test", customer.Email);
            Assert.Equal("Coleman-Blair", customer.LegalName);
            Assert.Equal("49-008-2965", customer.LegalNumber);
            Assert.Equal("http://hooli.com/logo.png", customer.LogoUrl);
            Assert.Equal("Gavin Belson", customer.Name);
            Assert.Equal("1-171-883-3711 x245", customer.Phone);
            Assert.Equal("CA", customer.State);
            Assert.Equal("http://hooli.com", customer.Url);
            Assert.Equal("91364", customer.Zipcode);
            Assert.Equal("EUR", customer.Currency);
            Assert.Equal("Europe/Paris", customer.Timezone);
            Assert.Equal("Europe/Paris", customer.ApplicableTimezone);

            Assert.Equal(3, customer.BillingConfiguration.InvoiceGracePeriod);
            Assert.Equal(PaymentProvider.Stripe, customer.BillingConfiguration.PaymentProvider);
            Assert.Equal("cus_12345", customer.BillingConfiguration.ProviderCustomerId);
            Assert.True(customer.BillingConfiguration.SyncWithProvider);
            Assert.Equal(12.5, customer.BillingConfiguration.VatRate);
        }
    }
}