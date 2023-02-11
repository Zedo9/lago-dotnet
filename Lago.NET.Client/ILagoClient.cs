using Lago.NET.Client.Clients;

namespace Lago.NET.Client
{
    public interface ILagoClient : IFluentInterface
    {
        IBillableMetricsClient BillableMetrics { get; }
        ICustomersClient Customers { get; }
    }
}