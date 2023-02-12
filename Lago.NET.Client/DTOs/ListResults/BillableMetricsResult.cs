using System.Collections.Generic;
using System.Text.Json.Serialization;

using Lago.NET.Client.DTOs.Shared;
using Lago.NET.Client.Models;

namespace Lago.NET.Client.DTOs.ListResults
{
    public class BillableMetricsResult : ListResult
    {
        [JsonPropertyName("billable_metrics")]
        public IEnumerable<BillableMetric> BillableMetrics { get; set; }
    }
}