using FluentMigrator;
using Nop.Data.Migrations;
using Nop.Plugin.API.ElisaIntegration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.API.ElisaIntegration.Data
{
    [SkipMigrationOnUpdate]
    [NopMigration("2022/11/03 13:15:17:6455442", "API.ElisaIntegration base schema")]
    public class SchemaMigration : AutoReversingMigration
    {
        #region Fields
        protected IMigrationManager _migrationManager;
        #endregion

        #region Ctor
        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }
        #endregion

        /// <summary>
        /// Collect the UP migration expressions
        /// </summary>
        public override void Up()
        {
            _migrationManager.BuildTable<CustomCart>(Create);
            _migrationManager.BuildTable<CustomCartItems>(Create);
        }
    }
}
