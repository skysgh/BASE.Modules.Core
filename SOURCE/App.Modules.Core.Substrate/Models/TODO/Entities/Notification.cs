namespace App.Modules.TmpSys.Shared.Models.TODO.Entities
{
    using App.Modules.TmpSys.Shared.Models.TODO.Entities.Enums;
    using App.Modules.TmpSys.Substrate.tmp.Models.Entities.Base;
    using System;
    using System.Diagnostics;


    /// <summary>
    /// System entity (not exposed to the system's exterior) for
    /// a <see cref="Notification"/> message to a user.
    /// </summary>
    public class Notification : TenantFKAuditedRecordStatedTimestampedGuidIdEntityBase
    {
        /// <summary>
        /// Notification Type
        /// </summary>
        public virtual NotificationType Type { get; set; }

        /// <summary>
        /// Notification Level.
        /// </summary>
        public virtual TraceLevel Level { get; set; }

        //For:
        /// <summary>
        /// FK of Principal Notification is for.
        /// </summary>
        public virtual Guid PrincipalFK { get; set; }

        /// <summary>
        /// Date time notification created
        /// </summary>
        public virtual DateTime DateTimeCreatedUtc { get; set; }
        /// <summary>
        /// Date time notification read
        /// </summary>
        public virtual DateTime? DateTimeReadUtc { get; set; }


        /// <summary>
        /// Notification from:
        /// <para>
        /// Source User or System identifier
        /// </para>
        /// </summary>
        public virtual string From { get; set; }

        /// <summary>
        /// Image for Notification
        /// </summary>
        public virtual string ImageUrl { get; set; }

        /// <summary>
        /// TODO: Describe better
        /// </summary>
        public virtual string Class { get; set; }

        /// <summary>
        ///     Status whether Message has been read.
        /// </summary>
        public virtual bool IsRead
        {
            get => DateTimeReadUtc.HasValue;
            set
            {
                if (value == false)
                {
                    DateTimeReadUtc = null;
                }
                else
                {
                    if (!DateTimeReadUtc.HasValue)
                    {
                        DateTimeReadUtc = DateTime.UtcNow;
                    }
                }
            }
        }

        /// <summary>
        ///     1-100% complete.
        /// </summary>
        public virtual int Value { get; set; }

        /// <summary>
        /// Rich Text of message.
        /// </summary>
        public virtual string Text { get; set; }
    }
}