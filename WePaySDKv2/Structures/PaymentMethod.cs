using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Structures
{
    // https://stage.wepay.com/developer/reference/structures#payment_method

    public class PaymentMethod
    {
        public string type { get; set; }
        public CreditCard credit_card { get; set; }
    }
}
