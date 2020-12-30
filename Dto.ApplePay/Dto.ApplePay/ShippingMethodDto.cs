using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Dto.ApplePay
{

    public class ShippingMethodDto {

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

    }

}
