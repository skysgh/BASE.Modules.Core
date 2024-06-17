namespace App.Modules.TmpSys.Shared.Models.TODO.Entities.TenancySpecific
{
    using App.Modules.TmpSys.Shared.Models.TODO.Entities;
    using App.Modules.TmpSys.Shared.Models.TODO.Entities.Enums;
    using App.Modules.TmpSys.Substrate.Models.Contracts;
    using App.Modules.TmpSys.Substrate.tmp.Models.Entities.Base;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// The profile (not same as Security Profile) of a Principal.
    /// </summary>
    public class PrincipalProfile : TenantFKAuditedRecordStatedTimestampedGuidIdEntityBase, IHasEnabled
    {

        /// <summary>
        /// Get/Set from when the Principal is enabled.
        /// </summary>
        public DateTime? EnabledBeginningUtc { get; set; }

        /// <summary>
        /// Get/Set until when the Principal is enabled (eg: Contract)
        /// </summary>
        public DateTime? EnabledEndingUtc { get; set; }

        /// <summary>
        /// Is the Principal Enabled.
        /// </summary>
        public virtual bool Enabled { get; set; }


        /// <summary>
        /// Display (user Modifiable) name of Principal
        /// </summary>
        public virtual string DisplayName { get; set; } = string.Empty;

        /// <summary>
        /// Get/Set the FK of the Data Classification of the Principal.
        /// </summary>
        public virtual NZDataClassification? DataClassificationFK { get; set; }
        /// <summary>
        /// Get/Set the Data Classification of the Principal.
        /// </summary>
        public virtual DataClassification? DataClassification { get; set; }

        /// <summary>
        /// Get/Set the Category of Principal
        /// </summary>
        public virtual PrincipalProfileCategory? Category { get; set; }
        /// <summary>
        /// Get/Set the FK of the Category of the Principal
        /// </summary>
        public virtual Guid CategoryFK { get; set; }


        /// <summary>
        /// Get the Collection of Tags associated.
        /// </summary>
        public virtual ICollection<PrincipalProfileTag> Tags
        {
            get
            {
                if (_tags == null)
                {
                    _tags = new Collection<PrincipalProfileTag>();
                }
                return _tags;
            }
            set => _tags = value;
        }
        private ICollection<PrincipalProfileTag>? _tags;




        /// <summary>
        /// Get the collection of properties of this Profile.
        /// </summary>
        public virtual ICollection<PrincipalProfileProperty> Properties
        {
            get
            {
                if (_properties == null)
                {
                    _properties = new Collection<PrincipalProfileProperty>();
                }
                return _properties;
            }
            set => _properties = value;
        }
        private ICollection<PrincipalProfileProperty>? _properties;

        /// <summary>
        /// Get the Claims associated to this <see cref="Principal"/>
        /// </summary>
        public virtual ICollection<PrincipalProfileClaim> Claims
        {
            get
            {
                if (_claims == null)
                {
                    _claims = new Collection<PrincipalProfileClaim>();
                }
                return _claims;
            }
            set => _claims = value;
        }
        private ICollection<PrincipalProfileClaim>? _claims;





    }
}