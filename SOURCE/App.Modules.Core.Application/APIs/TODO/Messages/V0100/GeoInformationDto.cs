using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Base.Shared.Models.Entities;
using App.Modules.Core.Shared.Models.TODO.Messages;

namespace App.Modules.Core.Application.APIs.TODO.Messages.V0100
{
    /// <summary>
    /// API DTO for system 
    /// <see cref="GeoInformation"/>
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
