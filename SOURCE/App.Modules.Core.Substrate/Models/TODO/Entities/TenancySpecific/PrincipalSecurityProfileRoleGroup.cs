namespace App.Modules.TmpSys.Shared.Models.TODO.Entities.TenancySpecific
{
    using App.Modules.TmpSys.Substrate.Models.Contracts;
    using App.Modules.TmpSys.Substrate.tmp.Models.Entities.Base;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// A Group of Roles
    /// </summary>
    public class PrincipalSecurityProfileRoleGroup
        : TenantFKAuditedRecordStatedTimestampedGuidIdEntityBase,
        IHasTitle,
        IHasTitleAndDescription,
        IHasParentFKNullable,
        IHasParentNullable<PrincipalSecurityProfileRoleGroup>
    {
        /// <summary>
        /// Get/Set the Title of the Group
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Get/Set the Description of the Group.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The FK of the parent Role Group (they're nested)
        /// </summary>
        public Guid? ParentFK { get; set; }
        /// <summary>
        /// The parent Role Group (they're nested)
        /// </summary>
        public PrincipalSecurityProfileRoleGroup? Parent { get; set; }

        /// <summary>
        /// Collection of child Role Groups.
        /// </summary>
        public ICollection<PrincipalSecurityProfileRoleGroup> AccountGroups
        {
            get
            {
                return _accountGroups ?? (_accountGroups = new Collection<PrincipalSecurityProfileRoleGroup>());
            }
            set
            {
                _accountGroups = value;
            }
        }
        /// <summary>
        /// TODO: Why public?
        /// </summary>
        public ICollection<PrincipalSecurityProfileRoleGroup>? _accountGroups;


        /// <summary>
        /// Collection of Roles in this Group.
        /// </summary>
        public ICollection<PrincipalSecurityProfileRole> Roles
        {
            get
            {
                return _roles ?? (_roles = new Collection<PrincipalSecurityProfileRole>());
            }
            set
            {
                _roles = value;
            }
        }

        /// <summary>
        /// TODO: Why public?
        /// </summary>
        public ICollection<PrincipalSecurityProfileRole>? _roles;

        //TODO: Could get large. Do we want this? Maybe it should only be on Account.
        //public ICollection<Account> Accounts { get; set; } 

    }

}

