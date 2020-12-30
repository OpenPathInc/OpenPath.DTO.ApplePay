using System.ComponentModel.DataAnnotations;

namespace OpenPath.Dto.ApplePay {

    public class ValidateMerchantSessionDto {

        [Required]
        [DataType(DataType.Url)]
        public string ValidationUrl { get; set; }

    }

}
