using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Api
{
    // https://stage.wepay.com/developer/reference/checkout#cancel

    public class CheckoutCancelRequest
    {
        public long checkout_id { get; set; }
        public string cancel_reason { get; set; }
    }
}
