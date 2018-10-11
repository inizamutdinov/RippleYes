using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteRepository.Contexts
{
    public class MigrationContext : BaseContext
    {
        public MigrationContext(string dbPath)
            : base(dbPath)
        {

        }

        public DbSet<Migration> Migrations { get; set; }
    }
}
