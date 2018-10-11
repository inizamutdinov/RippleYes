using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteRepository.Migrator
{
    internal abstract class MigrationBase
    {
        public MigrationBase(DbContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected readonly DbContext Context;

        public abstract int Version { get; }
        public abstract string Description { get; }

        protected abstract void Up();

        public void Do(int version)
        {
            if (Version > version)
            {
                Up();
                LogMigrate();
            }
        }

        protected void Execute(string query)
        {
            using (var conn = Context.Database.GetDbConnection())
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
        }

        private void LogMigrate()
        {
            Execute($"INSERT INTO [Migrations] VALUES(\"{Version}\",\"{Description}\")");
        }
    }
}
