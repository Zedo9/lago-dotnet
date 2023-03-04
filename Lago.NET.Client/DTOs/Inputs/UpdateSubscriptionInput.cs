using System;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class UpdateSubscriptionInput
    {
        /// <summary>
        /// Subscription display name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Start date of the subscription. Can only be modified for pending subscriptions that have not yet started.
        /// </summary>
        public DateTime SubscriptionDate { get; set; }
    }

    internal class UpdateSubscriptionInputWrapper
    {
        public UpdateSubscriptionInputWrapper(UpdateSubscriptionInput subscriptionInput)
        {
            Subscription = subscriptionInput;
        }

        public UpdateSubscriptionInput Subscription { get; set; }
    }
}