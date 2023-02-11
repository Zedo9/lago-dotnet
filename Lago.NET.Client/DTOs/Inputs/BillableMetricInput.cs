using System.Text.Json.Serialization;

using Lago.NET.Client.Enums;
using Lago.NET.Client.Models;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class BillableMetricInput
    {
        /// <summary>
        /// Code identifying the billable metric.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Billable metric name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Billable metric description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Field name used in events.
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// Aggregation type that is used in event calculation. 
        /// </summary>
        [JsonPropertyName("aggregation_type")]
        public AggregationType AggregationType { get; set; }

        /// <summary>
        /// Group (one or two dimensions) for pricing differently the billable metric
        /// </summary>
        [JsonPropertyName("group")]
        public Group Group { get; set; }
    }

    public class BillableMetricInputWrapper
    {
        public BillableMetricInputWrapper(BillableMetricInput billableMetricInput)
        {
            BillableMetric = billableMetricInput;
        }

        [JsonPropertyName("billable_metric")]
        public BillableMetricInput BillableMetric { get; set; }
    }
}