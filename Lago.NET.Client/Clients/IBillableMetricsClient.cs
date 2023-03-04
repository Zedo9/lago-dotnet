using System.Threading;
using System.Threading.Tasks;

using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.DTOs.ListResults;
using Lago.NET.Client.DTOs.Filters;
using Lago.NET.Client.Models;

using Refit;

namespace Lago.NET.Client.Clients
{
    public interface IBillableMetricsClient : IFluentInterface
    {
        async Task<BillableMetric> CreateAsync(
            CreateOrUpdateBillableMetricInput billableMetricInput,
            CancellationToken cancellationToken = default)
        {
            var result = await CreateAsyncInternal(
                new CreateOrUpdateBillableMetricInputWrapper(billableMetricInput),
                cancellationToken);

            return result?.BillableMetric;
        }

        async Task<BillableMetric> UpdateAsync(
            string code,
            CreateOrUpdateBillableMetricInput billableMetricInput,
            CancellationToken cancellationToken = default)
        {
            var result = await UpdateAsyncInternal(
                code,
                new CreateOrUpdateBillableMetricInputWrapper(billableMetricInput),
                cancellationToken);

            return result?.BillableMetric;
        }

        async Task<BillableMetric> DestroyAsync(
            string code,
            CancellationToken cancellationToken = default)
        {
            var result = await DeleteAsyncInternal(code, cancellationToken);

            return result?.BillableMetric;
        }

        async Task<BillableMetric> FindOneAsync(
            string code,
            CancellationToken cancellationToken = default)
        {
            var result = await FindOneAsyncInternal(code, cancellationToken);

            return result?.BillableMetric;
        }

        [Get("/billable_metrics")]
        Task<BillableMetricsResult> FindAllAsync(
             [Query] PageFilter pageFilter = null,
             CancellationToken cancellationToken = default);

        #region Internal
        [Post("/billable_metrics")]
        internal Task<BillableMetricWrapper> CreateAsyncInternal(
            [Body] CreateOrUpdateBillableMetricInputWrapper billableMetricInputWrapper,
            CancellationToken cancellationToken);

        [Put("/billable_metrics/{code}")]
        internal Task<BillableMetricWrapper> UpdateAsyncInternal(
            string code,
            [Body] CreateOrUpdateBillableMetricInputWrapper billableMetricInputWrapper,
            CancellationToken cancellationToken);

        [Delete("/billable_metrics/{code}")]
        internal Task<BillableMetricWrapper> DeleteAsyncInternal(
            string code,
            CancellationToken cancellationToken);

        [Get("/billable_metrics/{code}")]
        internal Task<BillableMetricWrapper> FindOneAsyncInternal(
            string code,
            CancellationToken cancellationToken);
        #endregion
    }
}