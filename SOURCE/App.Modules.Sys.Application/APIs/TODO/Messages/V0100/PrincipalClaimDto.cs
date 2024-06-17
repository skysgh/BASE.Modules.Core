namespace App.Modules.TmpSys.Application.APIs.TODO.Messages.V0100
{
    using System;
    using App.Modules.Core.Substrate.Models.Contracts;
    using App.Base.Shared.Models.Entities;
    using App.Base.Shared.Models.Enums;

    /// <summary>
    /// An API DTO
    /// for a Claim belonging to a Principal.
    /// </summary>
    public class PrincipalClaimDto
        :
        IHasGuidId,
        IHasRecordState,
        IHasPrincipalFK,
        IHasKeyGenericValue<string>
    {

        /// <summary>
        /// The authority supporting the claim
        /// </summary>
        public virtual string? AuthorityKey { get; set; }
        /// <summary>
        /// The Authorities signature of the Value
        /// </summary>
        public virtual string? Signature { get; set; }
        /// <summary>
        /// The Record Id
        /// </summary>
        public virtual Guid Id { get; set; }
        /// <summary>
        /// The unique key of the claim 
        /// </summary>
        public virtual string Key { get; set; } = string.Empty;

        /// <summary>
        /// The FK of the parent Principal
        /// <para>
        /// Note that no nagivation up property is provided.
        /// </para>
        /// </summary>
        public virtual Guid PrincipalFK { get; set; }

        /// <summary>
        /// The State of the record
        /// </summary>
        public virtual RecordPersistenceState RecordState { get; set; }

        /// <summary>
        /// The Claim's Value.
        /// </summary>
        public virtual string Value { get; set; } = string.Empty;   
    }
}