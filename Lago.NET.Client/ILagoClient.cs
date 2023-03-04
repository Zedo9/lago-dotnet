using Lago.NET.Client.Clients;

namespace Lago.NET.Client
{
    public interface ILagoClient : IFluentInterface
    {
        IBillableMetricsClient BillableMetrics { get; }

        ICustomersClient Customers { get; }

        IOrganizationsClient Organizations { get; }

        ISubscriptionsClient Subscriptions { get; }

        IWalletsClient Wallets { get; }

        IAddOnsClient AddOns { get; }

        ICouponsClient Coupons { get; }
    }
}