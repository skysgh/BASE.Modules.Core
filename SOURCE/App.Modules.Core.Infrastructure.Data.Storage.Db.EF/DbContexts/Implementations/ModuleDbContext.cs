using App.Modules.Base.Infrastructure.Factories;
using App.Modules.Base.Infrastructure.Services;
using App.Modules.Base.Infrastructure.Storage.Db.EF.DbContexts.Implementations.Base;
using App.Modules.Base.Infrastructure.Storage.Db.EF.Schema.Management;
using App.Modules.Base.Shared.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;


namespace App.Modules.Base.Infrastructure.Data.Storage.Db.EF.DbContexts.Implementations
{
    /// <summary>
    /// The Module specific DbContext (notice is has it's own Schema).
    /// <para>
    /// Inherits from the common <see cref="ModuleDbContextBase{TDbContext}"/> 
    /// where <c>AppDbContextBase.SaveChanges</c>
    /// and <c>AppDbContextBase.SaveChangesAsync</c>
    /// intercept the save operation, 
    /// to clean up new/updated objects
    /// </para>
    /// <para>
    /// Also (and very importantly) the base class' static Constructor 
    /// ensures its migration capabilities work from the commandline.
    /// </para>
    /// </summary>
    /// <seealso cref="ModuleDbContextBase{DbContext}" />


    public class ModuleDbContext : ModuleDbContextBase<ModuleDbContext>
    {

        /*
        /// <summary>
        /// Expost the Types/Tables specific to this DbContext
        /// </summary>
        public DbSet<NothingDefinedYet>? NothingDefinedYet { get; set; }
        */


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        /// <param name="modelBuilderOrchestrator"></param>
        /// <param name="dbContextPreCommitService"></param>
        /// <param name="loggerFactory"></param>
        public ModuleDbContext(
            DbContextOptions<ModuleDbContext> options, 
            IModelBuilderOrchestrator modelBuilderOrchestrator, 
            IDbContextPreCommitService dbContextPreCommitService, 
            ILoggerFactory loggerFactory) 
            : base(
                  ModuleConstants.DbSchemaKey, 
                  options, 
                  modelBuilderOrchestrator, 
                  dbContextPreCommitService, 
                  loggerFactory)
        {
        }


    }
}

