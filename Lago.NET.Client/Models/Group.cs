using System;

namespace Lago.NET.Client.Models
{
    public class Group
    {
        /// <summary>
        /// Unique identifier of the Coupon in Lago application.
        /// </summary>
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Coupon creation.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}