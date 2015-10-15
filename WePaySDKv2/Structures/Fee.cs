using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Structures
{
    // https://stage.wepay.com/developer/reference/structures#fee

    public class Fee
    {
        public decimal app_fee { get; set; }
        public string fee_payer { get; set; }
    }
}
