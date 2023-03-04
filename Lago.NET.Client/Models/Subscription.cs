using System;

using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class Subscription : CreateSubscriptionInput
    {
        /// <summary>
        /// Unique identifier of the Coupon in Lago application.
        /// </summary>
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Coupon creation.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Unique identifer of the customer in Lago application.
        /// </summary>
        public string LagoCustomerId { get; set; }

        /// <summary>
        /// Cancelation date of the subscription. It's not null when the subscription is canceled.
        /// </summary>
        /// <remarks>
        /// ISO 8601 datetime in UTC.
        /// </remarks>
        public DateTime CanceledAt { get; set; }

        /// <summary>
        /// Start date of the subscription. It could be null if the subscription is pending of canceled.
        /// </summary>
        /// <remarks>
        /// ISO 8601 datetime in UTC.
        /// </remarks>
        public DateTime StartedAt { get; set; }

        /// <summary>
        /// Status of the subscription. 
        /// </summary>
        public SubscriptionStatus Status { get; set; }

        /// <summary>
        /// Termination date of the subscription. 
        /// It's not null when the subscription is terminated.
        /// </summary>
        /// <remarks>
        /// ISO 8601 datetime in UTC.
        /// </remarks>
        public DateTime TerminatedAt { get; set; }

        /// <summary>
        /// Code identifying the previous plan.
        /// </summary>
        public string PreviousPlanCode { get; set; }

        /// <summary>
        /// Code identifying the next plan, in case of downgrade.
        /// </summary>
        public string NextPlanCode { get; set; }

        /// <summary>
        /// Date when the plan will be downgraded.
        /// </summary>
        /// <remarks>
        /// ISO 8601 datetime in UTC.
        /// </remarks>
        public DateTime DowngradePlanDate { get; set; }
    }

    public class SubscriptionWrapper
    {
        public Subscription Subscription { get; set; }
    }
}