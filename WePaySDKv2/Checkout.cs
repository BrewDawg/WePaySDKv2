using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WePaySDKv2.Api;

namespace WePaySDKv2
{
    public class Checkout
    {
        public CheckoutResponse Post(CheckoutCreateRequest req)
        {
            CheckoutResponse response;
            try
            {
                response = new WePayClient().Invoke<CheckoutCreateRequest, CheckoutResponse>(req, req.actionUrl, WePayConfig.accessToken);
            }
            catch (WePayException ex)
            {
                response = new CheckoutResponse();
                response.Error = ex;
            }

            return response;
        }
    }
}
