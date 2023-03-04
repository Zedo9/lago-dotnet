namespace Lago.NET.Client.Clients
{
    public class LagoClient : ILagoClient
    {
        public IBillableMetricsClient BillableMetrics { get; }

        public ICustomersClient Customers { get; }

        public IOrganizationsClient Organizations { get; }

        public ISubscriptionsClient Subscriptions { get; }

        public IWalletsClient Wallets { get; }

        public IAddOnsClient AddOns { get; }

        public ICouponsClient Coupons { get; }

        internal LagoClient(
            IBillableMetricsClient billableMetricsClient,
            ICustomersClient customersClient,
            IWalletsClient walletsClient,
            ISubscriptionsClient subscriptionsClient,
            IOrganizationsClient organizationsClient,
            IAddOnsClient addonsClient,
            ICouponsClient couponsClient)
        {
            BillableMetrics = billableMetricsClient;
            Customers = customersClient;
            Wallets = walletsClient;
            Organizations = organizationsClient;
            Subscriptions = subscriptionsClient;
            AddOns = addonsClient;
            Coupons = couponsClient;
        }
    }
}