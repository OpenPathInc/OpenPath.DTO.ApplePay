using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenPath.Dto.ApplePay
{
    public class DecryptedApplePayPaymentData
    {
        [JsonProperty("applicationPrimaryAccountNumber")]
        public string ApplicationPrimaryAccountNumber { get; set; }

        [JsonProperty("applicationExpirationDate")]
        public string ApplicationExpirationDate { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("transactionAmount")]
        public decimal TransactionAmount { get; set; }

        [JsonProperty("deviceManufacturerIdentifier")]
        public string DeviceManufacturerIdentifier { get; set; }

        [JsonProperty("paymentDataType")]
        public string PaymentDataType { get; set; }

        [JsonProperty("paymentData")]
        public PaymentDataDictionaryDto PaymentData { get; set; }
    }
}
