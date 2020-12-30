using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Dto.ApplePay
{

    public class PaymentDto {

        [JsonProperty("billingContact")]
        public ContactDto BillingContact { get; set; }

        [JsonProperty("shippingContact")]
        public ContactDto ShippingContact { get; set; }

        [JsonProperty("token")]
        public TokenDto Token { get; set; }

        [JsonProperty("paymentData")]
        public string PaymentData { get; set; }

    }

}
