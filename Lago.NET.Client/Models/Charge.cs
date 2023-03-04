using System;
using System.Collections.Generic;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class Charge
    {
        /// <summary>
        /// Unique identifier of the Charge in Lago application.
        /// </summary>
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Addon creation.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        public string LagoBillableMetricId { get; set; }
        public ChargeModel ChargeModel { get; set; }
        public Dictionary<string, string> Properties { get; set; }
    }
}