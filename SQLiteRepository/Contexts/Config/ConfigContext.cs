using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteRepository.Contexts
{
    public class ConfigContext : BaseContext
    {
        public ConfigContext(string dbPath)
            : base(dbPath)
        {
            
        }
        
        public DbSet<Config> Configs { get; set; }
    }
}
