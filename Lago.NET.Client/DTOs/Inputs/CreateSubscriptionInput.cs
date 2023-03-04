using System;

using Lago.NET.Client.Enums;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class CreateSubscriptionInput
    {
        /// <summary>
        /// Customer unique identifier in your application.
        /// </summary>
        public string ExternalCustomerId { get; set; }

        /// <summary>
        /// Code identifying the plan.
        /// </summary>
        /// <remarks>
        /// It must match the code property of one of the plans.
        /// </remarks>
        public string PlanCode { get; set; }

        /// <summary>
        /// Subscription display name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Unique external identifier of the subscription. Used as an idempotency key.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Billing time of the subscription. If not provided, it will default to calendar.
        /// </summary>
        public BillingTime BillingTime { get; set; }

        /// <summary>
        /// Can be used to create a subscription that started in the past or will start in the future. 
        /// Cannot be used to update the start date of a pending subscription or to schedule an upgrade/downgrade.
        /// </summary>
        public DateTime SubscriptionDate { get; set; }
    }

    internal class CreateSubscriptionInputWrapper
    {
        public CreateSubscriptionInputWrapper(CreateSubscriptionInput subscriptionInput)
        {
            Subscription = subscriptionInput;
        }

        public CreateSubscriptionInput Subscription { get; set; }
    }
}