using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Modules.TmpSys.Substrate.tmp.Attributes;
using App.Modules.TmpSys.Substrate.tmp.Constants;

namespace App.Modules.TmpSys.Shared.Models.TODO.ConfigurationSettings
{
    /// <summary>
    /// TODO: Describe
    /// </summary>
    public class ApiPermissionConfiguration
    {
        private string _serviceIdentifier;

        /// <summary>
        /// Constructor
        /// </summary>
        public ApiPermissionConfiguration()
        {
            _serviceIdentifier = string.Empty;
        }

        /// <summary>
        ///     The Service Identifier is the uri that was developed when the Service (not the Client)
        ///     was registered.
        ///     <para>
        ///         Used by both the API Provider, in its Setup phase, and the Consumer when it is about to make a remote API
        ///         call.
        ///     </para>
        ///     <para>eg: https://myb2c.onmicrosoft.com/example_webapi </para>
        ///     <para>
        ///         Note: When registering the Service as an App in the B2C, the Url should have been registered
        ///         with a final slash as it will be prefixed to Scopes (eg:'example.read' would become
        ///         `https://myb2c.onmicrosoft.com/example_webapi/exampe.read`) to disambiguate
        ///         across services with the same scope name.
        ///     </para>
        /// </summary>
        [Alias(AppModuleApiScopes.ServiceUrl)]
        public string ServiceIdentifier
        {
            get
            {
                if (!string.IsNullOrEmpty(_serviceIdentifier) && !_serviceIdentifier.EndsWith("/"))
                {
                    //Ensure it ends with a slash, so that it can be easily 
                    // joined up with Scope.
                    _serviceIdentifier += "/";
                }
                return _serviceIdentifier;
            }
            set => _serviceIdentifier = value;
        }
    }
}
