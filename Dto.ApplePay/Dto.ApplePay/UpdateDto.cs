using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenPath.Dto.ApplePay {
    
    public class UpdateDto {

        [JsonProperty("newTotal")]
        public LineItemDto NewTotal { get; set; }

        [JsonProperty("newLineItems")]
        public List<LineItemDto> NewLineItems { get; set; }

    }

}
