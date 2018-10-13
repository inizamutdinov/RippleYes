using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteRepository.Contexts
{
    public class StoryContext : BaseContext
    {
        public StoryContext(string dbPath)
            : base(dbPath)
        {
            
        }
        
        public DbSet<StoryContextItem> Items { get; set; }
    }
}
