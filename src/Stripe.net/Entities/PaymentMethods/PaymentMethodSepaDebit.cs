namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodSepaDebit : StripeEntity<PaymentMethodSepaDebit>
    {
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("branch_code")]
        public string BranchCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }
    }
}
