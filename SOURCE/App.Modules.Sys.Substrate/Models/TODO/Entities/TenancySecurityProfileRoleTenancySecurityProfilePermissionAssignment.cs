
namespace App.Modules.Core.Shared.Models.TODO.Entities
{
    using App.Modules.Core.Shared.Models.TODO.Entities.Enums;
    using App.Modules.Core.Substrate.tmp.Models.Entities.Base;
    using System;

    /// <summary>
    /// The assignment of a Tenancy Permission to Tenancy Role.
    /// </summary>
    public class TenancySecurityProfileRoleTenancySecurityProfilePermissionAssignment : TenantFKAuditedRecordStatedTimestampedNoIdEntityBase
    {
        /// <summary>
        /// The FK of the Role
        /// </summary>
        public Guid RoleFK { get; set; }

        /// <summary>
        /// The Role
        /// </summary>
        public TenancySecurityProfileAccountRole Role { get; set; }

        /// <summary>
        /// The FK of the Permission
        /// </summary>
        public Guid PermissionFK { get; set; }

        /// <summary>
        /// The Permission
        /// </summary>
        public TenancySecurityProfilePermission Permission { get; set; }

        /// <summary>
        /// The Assignment Type (+/-)
        /// </summary>
        public AssignmentType AssignmentType { get; set; }
    }

}

