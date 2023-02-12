namespace Lago.NET.Tests.Clients;

public class BillableMetricsClientTests
{
    private readonly MockHttpMessageHandler _mockHandler;
    private readonly ILagoClient _sut;

    public BillableMetricsClientTests()
    {
        _mockHandler = new MockHttpMessageHandler();
        _sut = LagoClientFactory.Create("apiKey", "https://api.getlago.com", _mockHandler.ToHttpClient());
    }

    [Fact]
    public async Task Valid_FindAll_Request()
    {
        _mockHandler
           .When(HttpMethod.Get, "https://api.getlago.com/api/v1/billable_metrics")
           .WithHeaders("Authorization", "Bearer apiKey")
           .WithHeaders("Accept", "application/json")
           .Respond("application/json", JsonFixtures.BillableMetricsJSON);

        var result = await _sut.BillableMetrics.FindAllAsync();

        Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac1000", result.BillableMetrics.ToList()[0].LagoId);
        Assert.Equal(1, result.Meta.CurrentPage);
    }

    [Fact]
    public async Task Valid_FindAll_WithPageFilter_Request()
    {
        _mockHandler
           .When(HttpMethod.Get, "https://api.getlago.com/api/v1/billable_metrics?per_page=2&page=1")
           .WithHeaders("Authorization", "Bearer apiKey")
           .WithHeaders("Accept", "application/json")
           .Respond("application/json", JsonFixtures.BillableMetricsJSON);

        var result = await _sut.BillableMetrics.FindAllAsync(new PageFilter(2, 1));

        Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac1000", result.BillableMetrics.FirstOrDefault()?.LagoId);
        Assert.Equal(1, result.Meta.CurrentPage);
    }

    [Fact]
    public async Task Valid_Create_Request()
    {
        _mockHandler
           .When(HttpMethod.Post, "https://api.getlago.com/api/v1/billable_metrics")
           .WithHeaders("Authorization", "Bearer apiKey")
           .WithHeaders("Accept", "application/json")
           .Respond("application/json", JsonFixtures.BillableMetricJSON);

        var createBillableMetricInput = new BillableMetricInput()
        {
            Name = "bm_name",
            Code = "bm_code",
            Description = "description",
            AggregationType = AggregationType.SumAgg,
            FieldName = "amount_sum",
            Group = new Group()
        };

        var result = await _sut.BillableMetrics.CreateAsync(createBillableMetricInput);

        Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac129b", result.LagoId);
        Assert.Equal("bm_code", result.Code);
    }

    [Fact]
    public async Task Valid_Update_Request()
    {
        _mockHandler
           .When(HttpMethod.Put, "https://api.getlago.com/api/v1/billable_metrics/bm_code")
           .WithHeaders("Authorization", "Bearer apiKey")
           .WithHeaders("Accept", "application/json")
           .Respond("application/json", JsonFixtures.BillableMetricJSON);

        var updateBillableMetricInput = new BillableMetricInput()
        {
            Name = "new_name",
        };

        var result = await _sut.BillableMetrics.UpdateAsync("bm_code", updateBillableMetricInput);

        Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac129b", result.LagoId);
        Assert.Equal("bm_code", result.Code);
    }

    [Fact]
    public async Task Valid_Destroy_Request()
    {
        _mockHandler
           .When(HttpMethod.Delete, "https://api.getlago.com/api/v1/billable_metrics/bm_code")
           .WithHeaders("Authorization", "Bearer apiKey")
           .WithHeaders("Accept", "application/json")
           .Respond("application/json", JsonFixtures.BillableMetricJSON);

        var result = await _sut.BillableMetrics.DestroyAsync("bm_code");

        Assert.Equal("b7ab2926-1de8-4428-9bcd-779314ac129b", result.LagoId);
    }
}