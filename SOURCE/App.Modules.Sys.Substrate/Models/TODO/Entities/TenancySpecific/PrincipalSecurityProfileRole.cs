namespace App.Modules.Core.Shared.Models.TODO.Entities.TenancySpecific
{
    using App.Modules.Core.Substrate.Models.Contracts;
    using App.Modules.Core.Substrate.tmp.Models.Entities.Base;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// A Role that can be assigned to a Principal's Security Profile.
    /// <para>
    /// Permissions are in turn (+/-) Assigned  to the Roles 
    /// (or directly to the Security Profile)
    /// </para>
    /// </summary>
    public class PrincipalSecurityProfileRole : TenantFKAuditedRecordStatedTimestampedGuidIdEntityBase, IHasTitleAndDescription
    {
        /// <summary>
        /// Get/Set the Title
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Get/Set the Description
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The Collection of Permissions assigned to this role.
        /// </summary>
        public ICollection<PrincipalSecurityProfilePermission> Permissions
        {
            get
            {
                return _permissions ?? (_permissions = new Collection<PrincipalSecurityProfilePermission>());
            }
            set
            {
                _permissions = value;
            }
        }
        /// <summary>
        /// TODO: Why Public?
        /// <para>
        /// TODO: Confirm documentation
        /// </para>
        /// </summary>
        public ICollection<PrincipalSecurityProfilePermission>? _permissions;



        /// <summary>
        /// The Assignement of Permissions to this Role.
        /// <para>
        /// TODO: Confirm documentation
        /// </para>
        /// </summary>
        public ICollection<PrincipalSecurityProfileRolePrincipalSecurityProfilePermissionAssignment> PermissionsAssignments
        {
            get
            {
                return _permissionsAssignments ?? (_permissionsAssignments = new Collection<PrincipalSecurityProfileRolePrincipalSecurityProfilePermissionAssignment>());
            }
            set
            {
                _permissionsAssignments = value;
            }
        }
        /// <summary>
        /// TODO: Why Public?
        /// </summary>
        public ICollection<PrincipalSecurityProfileRolePrincipalSecurityProfilePermissionAssignment>? _permissionsAssignments;

    }

}

