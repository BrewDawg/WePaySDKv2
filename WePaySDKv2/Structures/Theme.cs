using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePaySDKv2.Structures
{
    // https://stage.wepay.com/developer/reference/structures#theme

    public class Theme
    {
        public long theme_id { get; set; }
        public string name { get; set; }
        public string primary_color { get; set; }
        public string secondary_color { get; set; }
        public string background_color { get; set; }
        public string button_color { get; set; }
    }
}
