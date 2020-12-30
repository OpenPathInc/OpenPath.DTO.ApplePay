using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Dto.ApplePay
{

    public class TokenDto {

        [JsonProperty("paymentData")]
        public PaymentDataDto PaymentData { get; set; }

        [JsonProperty("paymentMethod")]
        public PaymentMethodDto PaymentMethod { get; set; }

        [JsonProperty("transactionIdentifier")]
        public string TransactionIdentifier { get; set; }

    }

}
