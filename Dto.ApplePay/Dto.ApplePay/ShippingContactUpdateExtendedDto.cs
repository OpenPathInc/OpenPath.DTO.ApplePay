using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Dto.ApplePay
{

    public class ShippingContactUpdateExtendedDto : UpdateDto {

        [JsonProperty("errors")]
        public List<ErrorDto> Errors { get; set; }

        [JsonProperty("newShippingMethods")]
        public List<ShippingMethodDto> NewShippingMethods { get; set; }

    }

}
