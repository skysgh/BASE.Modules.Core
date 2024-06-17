using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modules.TmpSys.Shared.Models.TODO.Messages
{
    /// <summary>
    /// A model of geo coordinates.
    /// <para>
    /// Used as a Query object by the IGeoLocationService. Or part of the Response.
    /// </para>
    /// </summary>
    public class GeoInformation
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GeoInformation()
        {
            IPAddress = string.Empty;
            CountryRegion = new GeoInformationCountryRegion();
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="countryRegion"></param>
        /// <param name="iPAddress"></param>
        public GeoInformation(GeoInformationCountryRegion countryRegion, string? iPAddress)
        {
            CountryRegion = countryRegion;
            IPAddress = iPAddress ?? string.Empty;
        }

        /// <summary>
        /// TODO: Describe
        /// </summary>
        public GeoInformationCountryRegion CountryRegion { get; set; }

        /// <summary>
        /// the IP
        /// </summary>
        public string IPAddress { get; set; }
    }

}
