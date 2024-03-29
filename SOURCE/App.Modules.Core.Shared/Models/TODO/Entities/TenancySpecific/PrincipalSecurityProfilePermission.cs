﻿namespace App.Modules.Core.Shared.Models.TODO.Entities.TenancySpecific
{
    using App.Base.Shared.Models.Contracts;
    using App.Base.Shared.Models.Entities;

    /// <summary>
    /// A Permission that can be assigned directly to a Security Profile.
    /// </summary>
    public class PrincipalSecurityProfilePermission : TenantFKAuditedRecordStatedTimestampedGuidIdEntityBase, IHasTitleAndDescription
    {
        /// <summary>
        /// It's title
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// It's Description
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }

}

