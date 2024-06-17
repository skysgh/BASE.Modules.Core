namespace App.Modules.Sys.Interface.Models._TOPARSE.V0100
{
    using System;
    using System.Collections.Generic;
    using App.Modules.Sys.Substrate.Models.Contracts;
    using App.Modules.Sys.Substrate.tmp.Factories;

    /// <summary>
    /// DTO for <c>SecurityProfilePermission</c>
    /// </summary>
    public class SecurityProfilePermissionDto  /* Avoid CONTRACTS on DTOs: UNDUE RISK OF INADVERTENT CHANGE */ : IHasGuidId
    {
        private string? _description = string.Empty;
        private string? _title = string.Empty;

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
        public string Title { get => _title ?? string.Empty; set => _title = value; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get => _description ?? string.Empty; set => _description = value; }


    }
}

