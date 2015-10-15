using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Structures
{
    // https://stage.wepay.com/developer/reference/structures#bank_data

    public class BankData
    {
        public string bank_name { get; set; }
        public string account_last_four { get; set; }
        public string note { get; set; }
    }
}
