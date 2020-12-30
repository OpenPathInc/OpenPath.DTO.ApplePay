using Newtonsoft.Json;

namespace OpenPath.Dto.ApplePay
{

    public class ShippingContactUpdateDto {

        [JsonProperty("shippingContact")]
        public ContactDto ShippingContact { get; set; }

        [JsonProperty("update")]
        public ShippingContactUpdateExtendedDto ShippingContactUpdate { get; set; }

    }

}
