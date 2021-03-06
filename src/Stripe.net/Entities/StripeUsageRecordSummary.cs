namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeUsageRecordSummary : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("invoice")]
        public string InvoiceId { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("period")]
        public StripePeriod StripePeriod { get; set; }

        [JsonProperty("subscription_item")]
        public string SubscriptionItemId { get; set; }

        [JsonProperty("total_usage")]
        public int TotalUsage { get; set; }
    }
}
