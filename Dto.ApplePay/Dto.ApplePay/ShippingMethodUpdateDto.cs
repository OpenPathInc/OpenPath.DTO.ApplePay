using Newtonsoft.Json;

namespace OpenPath.Dto.ApplePay {

    public class ShippingMethodUpdateDto {

        [JsonProperty("paymentMethod")]
        public ShippingMethodDto ShippingMethod { get; set; }

        [JsonProperty("update")]
        public UpdateDto ShippingMethodUpdate { get; set; }

    }

}
