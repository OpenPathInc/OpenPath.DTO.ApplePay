using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Dto.ApplePay
{
    
    public class PaymentAuthorizationResultDto {

        [JsonProperty("status"), JsonConverter(typeof(StringEnumConverter))]
        public Enumerator.Status Status { get; set; }

        [JsonProperty("errors")]
        public List<ErrorDto> Errors { get; set; }

    }

}
