using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OpenPath.Dto.ApplePay
{

    public class PaymentPassDto {

        [JsonProperty("primaryAccountIdentifier")]
        public string PrimaryAccountIdentifier { get; set; }

        [JsonProperty("primaryAccountNumberSuffix")]
        public string PrimaryAccountSuffix { get; set; }

        [JsonProperty("deviceAccountIdentifier")]
        public string DeviceAccountIdentifier {  get; set; }

        [JsonProperty("deviceAccountNumberSuffix")]
        public string DeviceAccountNumberSuffix { get; set; }

        [JsonProperty("activationState"), JsonConverter(typeof(StringEnumConverter))]
        public Enumerator.PaymentPassActivationState ActivationState { get; set; }

    }

}
