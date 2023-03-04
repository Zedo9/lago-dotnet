using System;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class Plan
    {
        /// <summary>
        /// Unique identifier of the Coupon in Lago application.
        /// </summary>
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Coupon creation.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Interval Interval { get; set; }
        public string Description { get; set; }
        public int AmountCents { get; set; }
        public string AmountCurrency { get; set; }
        public bool PayInAdvance { get; set; }
        public bool BillChargesMonthly { get; set; }
    }
}