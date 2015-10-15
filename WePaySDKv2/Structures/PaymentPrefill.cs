using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Structures
{
    // https://stage.wepay.com/developer/reference/structures#payments_prefill_info

    public class PaymentPrefill
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string region { get; set; }
        public string zip { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
    }
}