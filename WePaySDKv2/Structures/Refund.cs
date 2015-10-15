using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Structures
{
    // https://stage.wepay.com/developer/reference/structures#refund


    public class Refund
    {
        public decimal amount_refunded { get; set; }
        public string refund_reason { get; set; }
    }
}
