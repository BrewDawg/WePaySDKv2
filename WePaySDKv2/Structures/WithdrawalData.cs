using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Structures
{
    // https://stage.wepay.com/developer/reference/structures#withdrawal_data

    public class WithdrawalData
    {
        public long create_time { get; set; }
        public long capture_time { get; set; }
        public string redirect_uri { get; set; }
        public string callback_uri { get; set; }
        public string withdrawal_uri { get; set; }
    }
}
