using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Dto.ApplePay {

    /// <summary>
    /// A customizable error type that you create to indicate problems with the address or contact
    /// information on an Apple Pay sheet.
    /// When you determine that there is a problem with an address or contact information on the
    /// payment sheet, you can use ApplePayError to create a customized error message. Apple Pay
    /// highlights the area with an error and displays your message, making it easier for users to
    /// correct errors. Users must resolve any errors that you report on the Apple Pay sheet before
    /// they can finalize their transaction. The details you provide in an Apple Pay error include:
    /// code—An error code that identifies the area of the error. contactField—The specific field
    /// on the payment sheet with the error. message—Your custom error message to display on the
    /// payment sheet. For example, if you found an error in the postal code of the shipping
    /// address, create an ApplePayError with the custom message text "ZIP Code is invalid", as
    /// follows:
    /// new ApplePayError("shippingContactInvalid", "postalCode", "ZIP Code is invalid")
    /// On the payment sheet, Apple Pay highlights the postal code field and displays the message
    /// text.
    /// Note: ApplePayError requires Apple Pay API version 3 and later, and is only supported in
    /// Apple Pay JS API(not available in Payment Request API).
    /// </summary>
    public class ErrorDto {

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("contactField")]
        public string ContactField { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

    }

}
