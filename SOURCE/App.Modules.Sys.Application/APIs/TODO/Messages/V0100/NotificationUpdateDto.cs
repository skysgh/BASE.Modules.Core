using App.Modules.Core.Substrate.Models.Contracts;
using App.Modules.Core.Shared.Models.TODO.Entities;
using System;


namespace App.Modules.TmpSys.Application.APIs.TODO.Messages.V0100
{
    /// <summary>
    /// An API DTO of a
    /// <see cref="Notification"/>
    /// </summary>
    public class NotificationUpdateDto  /* Avoid CONTRACTS on DTOs: UNDUE RISK OF INADVERTENT CHANGE */ : IHasGuidId
    {
        /// <inheritdoc/>
        public virtual Guid Id { get; set; }

        /// <summary>
        /// Status whether Message has been read.
        /// </summary>
        public virtual bool Read { get; set; }


        /// <summary>
        /// The time the client read the message (if offline, will be different than time server records it).
        /// </summary>
        public virtual DateTime DateTimeModifiedUtc { get; set; }

    }
}
