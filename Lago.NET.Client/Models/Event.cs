using System;
using System.Collections.Generic;

namespace Lago.NET.Client.Models
{
    public class Event
    {
        /// <summary>
        /// Unique identifier of the Coupon in Lago application.
        /// </summary>
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Coupon creation.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        public string TransactionId { get; set; }

        public string LagoCustomerId { get; set; }

        public string ExternalCustomerId { get; set; }

        public string Code { get; set; }

        public DateTime Timestamp { get; set; }

        public Dictionary<string, string> Properties { get; set; }

        public string LagoSubscriptionId { get; set; }

        public string ExternalSubscriptionId { get; set; }
    }
}