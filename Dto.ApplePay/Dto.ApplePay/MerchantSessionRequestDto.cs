using Newtonsoft.Json;

namespace OpenPath.Dto.ApplePay {

    public class MerchantSessionRequestDto {

        [JsonProperty("merchantIdentifier")]
        public string MerchantIdentifier { get; set; }

        [JsonProperty("domainName")]
        public string DomainName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

    }

}
