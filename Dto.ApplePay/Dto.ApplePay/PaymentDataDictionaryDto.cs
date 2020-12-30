using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenPath.Dto.ApplePay
{
    public class PaymentDataDictionaryDto
    {
        [JsonProperty("onlinePaymentCryptogram")]
        public string OnlinePaymentCryptogram { get; set; }

        [JsonProperty("eciIndicator")]
        public string EciIndicator { get; set; }
    }
}
