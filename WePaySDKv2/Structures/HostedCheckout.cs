using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Structures
{
    // https://stage.wepay.com/developer/reference/structures#hosted_checkout

    public class HostedCheckout
    {
        public string redirect_uri { get; set; }
        public string fallback_uri { get; set; }
        public decimal shipping_fee { get; set; }
        public string mode { get; set; }
        public bool require_shipping { get; set; }
        public PaymentPrefill prefill_info { get; set; }
        public Theme theme_object { get; set; }
        public List<string> funding_sources { get; set; }
    }
}
