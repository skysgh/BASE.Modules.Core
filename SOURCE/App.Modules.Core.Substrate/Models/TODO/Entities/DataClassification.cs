namespace App.Modules.TmpSys.Shared.Models.TODO.Entities
{
    using App.Modules.TmpSys.Shared.Models.TODO.Entities.Enums;
    using App.Modules.TmpSys.Substrate.tmp.Models.Entities.Base;

    /// <summary>
    /// System entity (not exposed to the system's exterior) for
    /// a Data Classification (Normal, High, etc.) 
    /// to apply to a Resource.
    /// </summary>
    public class DataClassification : UntenantedAuditedRecordStatedTimestampedCustomIdReferenceDataEntityBase<NZDataClassification>
    {
    }
}