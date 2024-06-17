namespace App.Modules.TmpSys.Shared.Models.TODO.Entities
{
    using App.Modules.TmpSys.Substrate.tmp.Models.Entities.Base;

    /// <summary>
    /// System entity (not exposed to the system's exterior) for
    /// a Category of the <see cref="Principal"/>
    /// </summary>
    public class PrincipalCategory : UntenantedAuditedRecordStatedTimestampedGuidIdReferenceDataEntityBase
    {
    }

}