namespace App.Base.Shared.Models.Messages.API.V0100
{
    using System;
    using System.Collections.Generic;
    using App.Base.Shared.Factories;
    using App.Base.Shared.Models;

    /// <summary>
    /// DTO for <c>SecurityProfilePermission</c>
    /// </summary>
    public class SecurityProfilePermissionDto  /* Avoid CONTRACTS on DTOs: UNDUE RISK OF INADVERTENT CHANGE */ : IHasGuidId
    {
        private string? _description=String.Empty;
        private string? _title=String.Empty;

        /// <summary>
        /// Constructor
        /// </summary>
        public SecurityProfilePermissionDto()
        {
            ((IHasId<Guid>)this).Id = GuidFactory.NewGuid();

        }

        /// <summary>
        /// 
        /// </summary>
        Guid IHasId<Guid>.Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get => _title??String.Empty; set => _title = value; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get => _description??String.Empty; set => _description = value; }


    }
}

