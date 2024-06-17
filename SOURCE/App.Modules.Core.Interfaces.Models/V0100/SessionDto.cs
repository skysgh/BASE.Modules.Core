namespace App.Modules.Base.Interface.Models._TOPARSE.V0100
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using App.Modules.Base.Substrate.Models.Contracts;
    using App.Modules.Base.Substrate.tmp.Models.Messages._TOREVIEW.Entities;

    /// <summary>
    /// DTO for a <see cref="Session"/>
    /// </summary>
    public class SessionDto  /* Avoid CONTRACTS on DTOs: UNDUE RISK OF INADVERTENT CHANGE */ : IHasGuidId, IHasEnabled
    {
        private ICollection<SessionOperationDto> _operations = new Collection<SessionOperationDto>();
        private PrincipalDto? principal = null;

        /// <summary>
        /// Session Start
        /// </summary>
        public virtual DateTime StartDateTimeUtc { get; set; }

        /// <summary>
        /// Session Enabled
        /// </summary>
        public virtual bool Enabled { get; set; }

        /// <summary>
        /// Session Id
        /// </summary>
        public virtual Guid Id { get; set; }
        /// <summary>
        /// Session <see cref="PrincipalDto"/>
        /// </summary>
        public virtual PrincipalDto Principal { get => principal ?? new PrincipalDto(); set => principal = value; }



        /// <summary>
        /// Gets the Oeprations of this Session
        /// </summary>
        public virtual ICollection<SessionOperationDto> Operations
        {
            get
            {
                _operations ??= new Collection<SessionOperationDto>();
                return _operations;
            }
            set => _operations = value;
        }
    }
}