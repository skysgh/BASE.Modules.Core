using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modules.TmpSys.Shared.Models.TODO.Messages
{
    /// <summary>
    /// TODO: Describe
    /// </summary>
    public class GeoInformationCountryRegion
    {
        /// <summary>
        /// The ISO code of the country.
        /// </summary>
        public string IsoCode { get => _isoCode; set => _isoCode = value ?? string.Empty; }
        private string _isoCode = string.Empty;
    }
}
