using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class Charge
    {
        /// <summary>
        /// Unique identifier of the Charge in Lago application.
        /// </summary>
        [JsonPropertyName("lago_id")]
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Addon creation.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        public string LagoBillableMetricId { get; set; }
        public ChargeModel ChargeModel { get; set; }
        public Dictionary<string, string> Properties { get; set; }
    }
}