using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Dto.ApplePay
{

    public class PaymentMethodDto {

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public Enumerator.PaymentMethodType Type { get; set; }

        [JsonProperty("paymentPass")]
        public PaymentPassDto PaymentPass { get; set; }

    }

}
