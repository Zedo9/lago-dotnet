using System;
using System.Text.Json.Serialization;

using Lago.NET.Client.DTOs.Inputs;
using Lago.NET.Client.Enums;

namespace Lago.NET.Client.Models
{
    public class Subscription : CreateSubscriptionInput
    {
        /// <summary>
        /// Unique identifier of the Coupon in Lago application.
        /// </summary>
        [JsonPropertyName("lago_id")]
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Coupon creation.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Unique identifer of the customer in Lago application.
        /// </summary>
        [JsonPropertyName("lago_customer_id")]
        public string LagoCustomerId { get; set; }

        /// <summary>
        /// Cancelation date of the subscription. It's not null when the subscription is canceled.
        /// </summary>
        /// <remarks>
        /// ISO 8601 datetime in UTC.
        /// </remarks>
        [JsonPropertyName("canceled_at")]
        public DateTime CanceledAt { get; set; }

        /// <summary>
        /// Start date of the subscription. It could be null if the subscription is pending of canceled.
        /// </summary>
        /// <remarks>
        /// ISO 8601 datetime in UTC.
        /// </remarks>
        [JsonPropertyName("started_at")]
        public DateTime StartedAt { get; set; }

        /// <summary>
        /// Status of the subscription. 
        /// </summary>
        [JsonPropertyName("status")]
        public SubscriptionStatus Status { get; set; }

        /// <summary>
        /// Termination date of the subscription. 
        /// It's not null when the subscription is terminated.
        /// </summary>
        /// <remarks>
        /// ISO 8601 datetime in UTC.
        /// </remarks>
        [JsonPropertyName("terminated_at")]
        public DateTime TerminatedAt { get; set; }

        /// <summary>
        /// Code identifying the previous plan.
        /// </summary>
        [JsonPropertyName("previous_plan_code")]
        public string PreviousPlanCode { get; set; }

        /// <summary>
        /// Code identifying the next plan, in case of downgrade.
        /// </summary>
        [JsonPropertyName("next_plan_code")]
        public string NextPlanCode { get; set; }

        /// <summary>
        /// Date when the plan will be downgraded.
        /// </summary>
        /// <remarks>
        /// ISO 8601 datetime in UTC.
        /// </remarks>
        [JsonPropertyName("downgrade_plan_date")]
        public DateTime DowngradePlanDate { get; set; }
    }

    public class SubscriptionWrapper
    {
        [JsonPropertyName("subscription")]
        public Subscription Subscription { get; set; }
    }
}