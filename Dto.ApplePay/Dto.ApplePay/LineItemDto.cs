using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OpenPath.Dto.ApplePay {

    /// <summary>
    /// A set of line items that explain recurring payments and additional charges and discounts.
    /// Use lineItems to explain additional charges, discounts, and pending costs. Provide the
    /// total separately, in the total property. Line items are not required in a
    /// ApplePayPaymentRequest, but cannot be empty if they are present. The example in Listing 1
    /// shows line items that include a subtotal, free shipping, and estimated tax.
    /// </summary>
    public class LineItemDto {

        /// <summary>
        /// A value that indicates whether the line item is final or pending.
        /// See ApplePayLineItemType for valid values. The default value is final. Note that if a
        /// line item's type is pending, the Apple Pay payment sheet does not display the value in
        /// amount, and instead displays "pending". If a line item's type is final, the payment
        /// sheet displays the value in amount.
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public Enumerator.LineItemType Type { get; set; }

        /// <summary>
        /// Required. A short, localized description of the line item.
        /// Provide the label in title case—for example, VAT Tax, Gift Wrap and Card, or Discount.
        /// The label cannot be empty. Omit any punctuation and whitespace after the label. The
        /// label is formatted for display by the framework.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// Required. The monetary amount of the line item.
        /// This number must follow the regular expression -?[0-9]+(\.[0-9][0-9])?. The amount is
        /// required and cannot be empty. You specify the currency for the entire transaction
        /// including line items by setting the currencyCode property in ApplePayPaymentRequest.
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

    }

}
