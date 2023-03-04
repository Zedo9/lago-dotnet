using Lago.NET.Client.Enums;
using Lago.NET.Client.Models;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class CreateOrUpdateBillableMetricInput
    {
        /// <summary>
        /// Code identifying the billable metric.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Billable metric name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Billable metric description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Field name used in events.
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Aggregation type that is used in event calculation. 
        /// </summary>
        public AggregationType AggregationType { get; set; }

        /// <summary>
        /// Group (one or two dimensions) for pricing differently the billable metric
        /// </summary>
        public Group Group { get; set; }
    }

    internal class CreateOrUpdateBillableMetricInputWrapper
    {
        public CreateOrUpdateBillableMetricInputWrapper(CreateOrUpdateBillableMetricInput billableMetricInput)
        {
            BillableMetric = billableMetricInput;
        }

        public CreateOrUpdateBillableMetricInput BillableMetric { get; set; }
    }
}