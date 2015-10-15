using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Api
{
    // https://stage.wepay.com/developer/reference/checkout#find

    public class CheckoutFindRequest
    {
        public long account_id { get; set; }
        public long start { get; set; }
        public long limit { get; set; }
        public string reference_id { get; set; }
        public string state { get; set; }
        public long preapproval_id { get; set; }
        public long start_time { get; set; }
        public long end_time { get; set; }
        public string sort_order { get; set; }
        public decimal shipping_fee { get; set; }
    }
}