namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentMandateDataCustomerAcceptanceOptions : INestedOptions
    {
        /// <summary>
        /// <see cref="DateTime"/> at which the customer accepted the Mandate.
        /// </summary>
        [JsonProperty("accepted_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// If this is a Mandate accepted offline, this hash contains details about the offline
        /// acceptance.
        /// </summary>
        [JsonProperty("offline")]
        public PaymentIntentMandateDataCustomerAcceptanceOfflineOptions Offline { get; set; }

        /// <summary>
        /// If this is a Mandate accepted online, this hash contains details about the online
        /// acceptance.
        /// </summary>
        [JsonProperty("online")]
        public PaymentIntentMandateDataCustomerAcceptanceOnlineOptions Online { get; set; }

        /// <summary>
        /// The type of customer acceptance information included with the Mandate. One of
        /// <c>online</c> or <c>offline</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
