using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Structures
{
    // https://stage.wepay.com/developer/reference/structures#chargeback

    public class ChargeBack
    {
        public decimal amount_chargeback { get; set; }
        public string dispute_uri { get; set; }
    }
}
