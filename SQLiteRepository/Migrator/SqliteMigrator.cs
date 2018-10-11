using IRepository.Migrator;
using SQLiteRepository.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace SQLiteRepository.Migrator
{
    public class SqliteMigrator : IMigrator
    {
        public SqliteMigrator(string dbPath)
        {
            DbPath = dbPath ?? throw new ArgumentNullException(nameof(dbPath));
        }

        private readonly string DbPath;

        public void Run()
        {
            var currentVersion = 0;
            using (var db = new MigrationContext(DbPath))
            {
                db.Database.EnsureCreated();
                if (db.Migrations.Any())
                    currentVersion = db.Migrations.Max(t => t.Number);

                new Migration_001(db).Do(currentVersion);
            }

        }
    }
}
