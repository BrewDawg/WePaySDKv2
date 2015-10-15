using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WePaySDKv2.Structures;

namespace WePaySDKv2.Api
{
    // https://stage.wepay.com/developer/reference/checkout#find

    public class CheckoutResponse
    {
        [JsonIgnore]
        public WePayException Error { get; set; }

        public long checkout_id { get; set; }
        public long account_id { get; set; }
        public string type { get; set; }
        public string short_description { get; set; }
        public string currency { get; set; }
        public int amount { get; set; }
        public string state { get; set; }
        public string soft_descriptor { get; set; }
        public bool auto_capture { get; set; }
        public long create_time { get; set; }
        public string delivery_type { get; set; }
        public decimal gross { get; set; }
        public string long_description { get; set; }
        public string reference_id { get; set; }
        public string callback_uri { get; set; }
        public Fee fee { get; set; }
        public ChargeBack chargeback { get; set; }
        public Refund refund { get; set; }
        public HostedCheckout hosted_checkout { get; set; }
        public Payer payer { get; set; }
        public PaymentMethod payment_method { get; set; }
    }
}
