using App.Modules.Core.Substrate.Models.Contracts;
using App.Modules.Core.Substrate.tmp.Models.Entities.Base;

namespace App.Modules.Core.Shared.Models.TODO.Entities
{
    /// <summary>
    /// System entity (not exposed to the system's exterior) for
    /// an Account to which Users and Resources belong.
    /// </summary>
    public class Account : UntenantedAuditedRecordStatedTimestampedGuidIdEntityBase, IHasEnabled
    {
        /// <summary>
        /// Get/Set whether account is enabled or not.
        /// </summary>
        public bool Enabled { get; set; }
    }

}
