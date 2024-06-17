using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace App.Modules.Core.Shared.Models.TODO.Messages
{

    /// <summary>
    /// Azure Maps Search response
    /// </summary>
    public class AzureMapsSearchResponse
    {
        private AzureMapsSearchResponseResult[] results = new AzureMapsSearchResponseResult[0];

        /// <summary>
        /// The array of <see cref="AzureMapsSearchResponseResult"/>
        /// </summary>
        [JsonPropertyName("results")]
        public AzureMapsSearchResponseResult[] Results { get => results; set => results = value; }
    }

    /// <summary>
    /// A single Azure Maps response, 
    /// <para>
    /// Generally within an array, within
    /// <see cref="AzureMapsSearchResponse"/>
    /// </para>
    /// </summary>
    public class AzureMapsReverseSearchResponse
    {
        /// <summary>
        /// a list of <see cref="AzureMapsResponseAddress"/>.
        /// </summary>
        [JsonPropertyName("addresses")]
        public List<AzureMapsResponseAddress> Addresses
        {
            get { return _addresses ?? (_addresses = new List<AzureMapsResponseAddress>()); }
        }

        private List<AzureMapsResponseAddress>? _addresses;
    }


    /// <summary>
    /// A single Azure Maps Search Response
    /// </summary>
    public class AzureMapsSearchResponseResult
    {
        private string _type = string.Empty;
        private string _score = string.Empty;
        private AzureMapsResponseAddress? _address;
        private AzureMapResponsePosition? _position;

        /// <summary>
        /// The Type of response.
        /// </summary>
        [JsonPropertyName("results")]
        string Type { get => _type; set => _type = value; }


        /// <summary>
        /// The response score.
        /// </summary>
        [JsonPropertyName("score")]
        string Score { get => _score; set => _score = value; }

        /// <summary>
        /// The Response <see cref="AzureMapsResponseAddress"/>
        /// </summary>
        [JsonPropertyName("address")]
        public AzureMapsResponseAddress Address { get => _address ?? new AzureMapsResponseAddress(); set => _address = value; }

        /// <summary>
        /// The response <see cref="AzureMapResponsePosition"/>
        /// </summary>
        [JsonPropertyName("position")]
        public AzureMapResponsePosition Position { get { return _position ?? new AzureMapResponsePosition(); } set => _position = value; }
    }

    /// <summary>
    /// Azure Maps response for Position.
    /// </summary>
    public class AzureMapResponsePosition
    {
        private string latitude = string.Empty;
        private string longitude = string.Empty;

        /// <summary>
        /// Latitude
        /// </summary>
        [JsonPropertyName("lat")]
        public string Latitude { get => latitude; set => latitude = value; }

        /// <summary>
        /// Longitude
        /// </summary>
        [JsonPropertyName("lon")]
        public string Longitude { get => longitude; set => longitude = value; }
    }


    /// <summary>
    /// Response from Azure Maps.
    /// </summary>
    public class AzureMapsResponseAddress
    {
        private string? freeFormAddress = string.Empty;
        private string? postalCodeExtended = string.Empty;
        private string? postalCode = string.Empty;
        private string? countryCode = string.Empty;
        private string? countryCodeISO3 = string.Empty;
        private string? buildingNumber = string.Empty;
        private string? streetNumber = string.Empty;
        private string? street = string.Empty;
        private string? streetName = string.Empty;
        private string? streetNameAndNumber = string.Empty;
        private string? municipalitySubDivision = string.Empty;
        private string? municipality = string.Empty;
        private string? countrySecondarySubdivision;
        private string? countrySubdivision = string.Empty;
        private string? country = string.Empty;
        private string[] routeNumbers = new string[0];
        /// <summary>
        /// Address Building Number
        /// </summary>
        [JsonPropertyName("buildingNumber")]
        public string BuildingNumber { get => buildingNumber ?? string.Empty; set => buildingNumber = value; }
        /// <summary>
        /// Address Street number
        /// </summary>
        [JsonPropertyName("streetNumber")]
        public string StreetNumber { get => streetNumber ?? string.Empty; set => streetNumber = value; }

        /// <summary>
        /// Address Street
        /// </summary>
        [JsonPropertyName("street")]
        public string Street { get => street ?? string.Empty; set => street = value; }
        /// <summary>
        /// Address Street name
        /// </summary>
        [JsonPropertyName("streetName")]
        public string StreetName { get => streetName ?? string.Empty; set => streetName = value; }
        /// <summary>
        /// Address Street name and Number
        /// </summary>
        [JsonPropertyName("streetNameAndNumber")]
        public string StreetNameAndNumber { get => streetNameAndNumber ?? string.Empty; set => streetNameAndNumber = value; }
        /// <summary>
        /// Address Municipality Subdivision
        /// </summary>
        [JsonPropertyName("municipalitySubDivision")]
        public string MunicipalitySubDivision { get => municipalitySubDivision ?? string.Empty; set => municipalitySubDivision = value; }
        /// <summary>
        /// Address Municipality
        /// </summary>
        [JsonPropertyName("municipality")]
        public string Municipality { get => municipality ?? string.Empty; set => municipality = value; }

        /// <summary>
        /// Address Street number
        /// </summary>
        [JsonPropertyName("countrySecondarySubdivision")]
        public string CountrySecondarySubdivision { get => countrySecondarySubdivision ?? string.Empty; set => countrySecondarySubdivision = value; }

        /// <summary>
        /// Address Country Subdivision
        /// </summary>
        [JsonPropertyName("countrySubdivision")]
        public string CountrySubdivision { get => countrySubdivision ?? string.Empty; set => countrySubdivision = value; }

        /// <summary>
        /// Address Country Code ISO3
        /// </summary>
        [JsonPropertyName("countryCodeISO3")]
        public string CountryCodeISO3 { get => countryCodeISO3 ?? string.Empty; set => countryCodeISO3 = value; }
        /// <summary>
        /// Address Country Code
        /// </summary>
        [JsonPropertyName("countryCode")]
        public string CountryCode { get => countryCode ?? string.Empty; set => countryCode = value; }
        /// <summary>
        /// Address Country
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get => country ?? string.Empty; set => country = value; }
        /// <summary>
        /// Address Postal Code
        /// </summary>
        [JsonPropertyName("postalCode")]
        public string PostalCode { get => postalCode ?? string.Empty; set => postalCode = value; }
        /// <summary>
        /// Address Extended Postal Code
        /// </summary>
        [JsonPropertyName("extendedPostalCode")]
        public string PostalCodeExtended { get => postalCodeExtended ?? string.Empty; set => postalCodeExtended = value; }

        /// <summary>
        /// Address Free form
        /// </summary>
        [JsonPropertyName("freeformAddress")]
        public string FreeFormAddress { get => freeFormAddress ?? string.Empty; set => freeFormAddress = value; }

        /// <summary>
        /// Address Extended Free Form Address
        /// </summary>
        [JsonPropertyName("freeformAddressExtended")]
        public string ExtendedFreeFormAddress
        {
            get
            {
                return FreeFormAddress + ", " + Country;
            }
        }

        /// <summary>
        /// Address Route numbers
        /// </summary>
        [JsonPropertyName("routeNumbers")]
        public string[] RouteNumbers { get => routeNumbers; set => routeNumbers = value; }
    }


}

