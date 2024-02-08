namespace App.Modules.Core.Shared.Models.TODO.Entities
{
    using App.Base.Shared.Models.Entities.Base;
    using App.Modules.Core.Shared.Models.TODO.Entities.Enums;

    /// <summary>
    /// System entity (not exposed to the system's exterior) for
    /// a Data Classification (Normal, High, etc.) 
    /// to apply to a Resource.
    /// </summary>
    public class DataClassification : UntenantedAuditedRecordStatedTimestampedCustomIdReferenceDataEntityBase<NZDataClassification>
    {
    }
}