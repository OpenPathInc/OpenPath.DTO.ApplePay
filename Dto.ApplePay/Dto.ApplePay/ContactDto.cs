using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenPath.Dto.ApplePay
{
    public class ContactDto {

        [JsonProperty("addressLines")]
        public List<string> AddressLines { get; set; }

        /// <summary>
        /// The Administrative Area is that country's State, Province, Etc.
        /// </summary>
        [JsonProperty("administrativeArea")]
        public string AdministrativeArea { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// This is the contacts last name
        /// </summary>
        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        /// <summary>
        /// This is the customers first name
        /// </summary>
        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// This is the name of the city
        /// </summary>
        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("phoneticFamilyName")]
        public string PhoneticFamilyName { get; set; }

        [JsonProperty("phoneticGivenName")]
        public string PhoneticGivenName { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("subAdministrativeArea")]
        public string SubAdministrativeArea { get; set; }

        [JsonProperty("subLocality")]
        public string SubLocality { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

    }
}
