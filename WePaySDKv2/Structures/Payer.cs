using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Structures
{
    // https://stage.wepay.com/developer/reference/structures#payer

    public class Payer
    {
        public string name { get; set; }
        public string email { get; set; }
        public string home_address { get; set; }
    }
}
