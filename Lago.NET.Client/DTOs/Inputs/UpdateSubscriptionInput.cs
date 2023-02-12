using System;
using System.Text.Json.Serialization;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class UpdateSubscriptionInput
    {
        /// <summary>
        /// Subscription display name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Start date of the subscription. Can only be modified for pending subscriptions that have not yet started.
        /// </summary>
        [JsonPropertyName("subscription_date")]
        public DateTime SubscriptionDate { get; set; }
    }

    internal class UpdateSubscriptionInputWrapper
    {
        public UpdateSubscriptionInputWrapper(UpdateSubscriptionInput subscriptionInput)
        {
            Subscription = subscriptionInput;
        }

        [JsonPropertyName("subscription")]
        public UpdateSubscriptionInput Subscription { get; set; }
    }
}