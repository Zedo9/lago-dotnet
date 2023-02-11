using System;
using System.Text.Json.Serialization;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class BillableMetric
    {
        /// <summary>
        /// Unique identifier of the Billable Metric in Lago application.
        /// </summary>
        [JsonPropertyName("lago_id")]
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Billable Metric creation.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

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
    }

    public class BillableMetricWrapper
    {
        [JsonPropertyName("billable_metric")]
        public BillableMetric BillableMetric { get; set; }
    }
}