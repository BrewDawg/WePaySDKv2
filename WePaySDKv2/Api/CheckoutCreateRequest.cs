using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WePaySDKv2.Structures;

namespace WePaySDKv2.Api
{
    // https://stage.wepay.com/developer/reference/checkout#create

    public class CheckoutCreateRequest
    {
        [JsonIgnore]
        public readonly string actionUrl = @"checkout/create";

        public long account_id { get; set; }
        public decimal amount { get; set; }
        public string type { get; set; }
        public string currency { get; set; }
        public string short_description { get; set; }
        public string long_description { get; set; }
        public EmailMessage email_message { get; set; }
        public string delivery_type { get; set; }
        public Fee fee { get; set; }
        public string callback_uri { get; set; }
        public bool auto_capture { get; set; }
        public HostedCheckout hosted_checkout { get; set; }
    }
}
