using System;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class BillableMetric
    {
        /// <summary>
        /// Unique identifier of the Billable Metric in Lago application.
        /// </summary>
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Billable Metric creation.
        /// </summary>
        public DateTime CreatedAt { get; set; }

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
    }

    internal class BillableMetricWrapper
    {
        public BillableMetric BillableMetric { get; set; }
    }
}