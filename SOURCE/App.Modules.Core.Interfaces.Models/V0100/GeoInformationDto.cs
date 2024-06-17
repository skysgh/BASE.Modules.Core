using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modules.Sys.Interface.Models._TOPARSE.V0100
{
    /// <summary>
    /// API DTO for system 
    /// <c>GeoInformation</c>
    /// </summary>
    public class GeoInformationDto
    {
        /// <summary>
        /// Country Code.
        /// </summary>
        public GeoInformationCountryRegionDto? CountryRegion { get; set; }

        /// <summary>
        /// IP address
        /// </summary>
        public string? IPAddress { get; set; }
    }
}
