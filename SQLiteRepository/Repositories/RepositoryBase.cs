using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteRepository.Repositories
{
    public class RepositoryBase
    {
        public RepositoryBase(string dbPath)
        {
            DbPath = dbPath ?? throw new ArgumentNullException(nameof(dbPath));
        }

        protected string DbPath;
    }
}
