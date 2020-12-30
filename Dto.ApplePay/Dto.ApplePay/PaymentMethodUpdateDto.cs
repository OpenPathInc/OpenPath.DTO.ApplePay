using Newtonsoft.Json;
using OpenPath.Dto.ApplePay;

namespace OpenPath.Dto.ApplePay
{

    public class PaymentMethodUpdateDto {

        [JsonProperty("paymentMethod")]
        public PaymentMethodDto PaymentMethod { get; set; }

        [JsonProperty("update")]
        public UpdateDto PaymentMethodUpdate { get; set; }

    }

}
