namespace App.Modules.Core.Shared.Models.TODO.Entities
{
    using App.Base.Shared.Models.Entities.Base;

    /// <summary>
    /// System entity (not exposed to the system's exterior) for
    /// a Tag associated to a <see cref="Principal"/>
    /// </summary>
    public class PrincipalTag : UntenantedAuditedRecordStatedTimestampedGuidIdReferenceDataEntityBase
    {
    }
}