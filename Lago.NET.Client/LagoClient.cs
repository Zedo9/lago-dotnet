
namespace Lago.NET.Client.Clients
{
    public class LagoClient : ILagoClient
    {
        public IBillableMetricsClient BillableMetrics { get; }
        public ICustomersClient Customers { get; }
        internal LagoClient(
            IBillableMetricsClient billableMetricsClient,
            ICustomersClient customersClient)
        {
            BillableMetrics = billableMetricsClient;
            Customers = customersClient;
        }
    }
}