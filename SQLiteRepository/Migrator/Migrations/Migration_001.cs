using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteRepository.Migrator
{
    internal class Migration_001 : MigrationBase
    {
        public Migration_001(DbContext context)
            : base(context)
        {

        }

        public override int Version => 1;
        public override string Description => "Первая миграция";

        protected override void Up()
        {
            Execute("CREATE TABLE \"Configs\" ( \"Key\" TEXT NOT NULL CONSTRAINT \"PK_Configs\" PRIMARY KEY, \"Value\" TEXT NULL )");
        }
    }
}
