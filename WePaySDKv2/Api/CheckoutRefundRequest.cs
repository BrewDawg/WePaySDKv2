using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Api
{
    public class CheckoutRefundRequest
    {
        public int checkout_id { get; set; }
        public string cancel_reason { get; set; }
    }
}
