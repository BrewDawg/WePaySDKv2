using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Structures
{
    // https://stage.wepay.com/developer/reference/structures#email_message

    public class EmailMessage
    {
        public string to_payee { get; set; }
        public string to_payer { get; set; }
    }
}
