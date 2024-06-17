using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Modules.Core.Substrate.Models.Contracts;
using App.Modules.Core.Substrate.Models.Contracts.Enums;
using App.Modules.Core.Substrate.tmp.Factories;

namespace App.Modules.Core.Shared.Models.TODO.Entities
{
    /// <summary>
    /// TODO: Describe better
    /// </summary>
    public class IdentityProvider : IHasGuidId, IHasTimestamp, IHasRecordState, IHasKey
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public IdentityProvider()
        {
            GuidFactory.NewGuid();
        }

        /// <summary>
        /// TODO: Describe better
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// TODO: Describe better
        /// </summary>
        public byte[] Timestamp { get; set; }
        /// <summary>
        /// TODO: Describe better
        /// </summary>
        public RecordPersistenceState RecordState { get; set; }

        /// <summary>
        /// TODO: Describe better
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// TODO: Describe better
        /// </summary>

        public string ProviderKey { get; set; }
        /// <summary>
        /// TODO: Describe better
        /// </summary>
        public string UserId { get; set; }
    }
}
