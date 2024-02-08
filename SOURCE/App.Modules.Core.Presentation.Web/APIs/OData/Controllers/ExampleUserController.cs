using App.Base.Infrastructure.Services.Implementations;
using App.Base.Presentation.Web.APIs.OData.Controllers.Base;
using App.Modules.Core.Presentation.Web.APIs.Constants;
using Microsoft.AspNetCore.Mvc;

namespace App.Modules.Core.Presentation.Web.APIs.OData.Controllers
{
    /// <summary>
    /// Temp Doc
    /// </summary>
    /// 
    [Route(Route)]
    ////For Swagger:
    [ApiExplorerSettings(GroupName = ModuleApiRoutingConstants.Protocols.OData.GroupIdentifier)]
    [Produces("application/json")]
    public class ExampleUserController : AppBasicODataControllerBase 
    {
        /// <summary>
        /// Name of Controller.
        /// <para>
        /// Unique per Protocol per Module.
        /// </para>
        /// <para>
        /// Combined with the Module Key
        /// used to develop the 
        /// Route to the Controller.
        /// </para>
        /// <para>
        /// Note that when a Controller is OData enabled, 
        /// the Name is used to register the 
        /// route in the OData EDM Model.
        /// </para>
        /// </summary>
        internal const string Name = "ExampleUser";

        /// <summary>
        /// The unique Route to the Controller, combining
        /// <list type="bullet">
        /// <item>Module Key</item>
        /// <item>Protocol based Service Root</item>
        /// <item>API Version</item>
        /// <item>Controller Name</item>
        /// </list>
        /// </summary>
        internal const string Route = $"{ModuleApiRoutingConstants.Protocols.OData.RoutePrefix}/{Name}";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="principalService"></param>
        public ExampleUserController(PrincipalService principalService):
            base(principalService)
        {

        }
    }
}