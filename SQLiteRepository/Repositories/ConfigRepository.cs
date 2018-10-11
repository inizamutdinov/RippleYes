using IRepository;
using SQLiteRepository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteRepository.Repositories
{
    public class ConfigRepository : RepositoryBase, IConfigRepository
    {
        public ConfigRepository(string dbPath)
            : base(dbPath)
        {

        }

        public void Clear()
        {
            using (var context = new ConfigContext(DbPath))
            {
                context.Configs.RemoveRange(context.Configs);
            }
        }

        public void Delete(string key)
        {
            using (var context = new ConfigContext(DbPath))
            {
                context.Configs.Remove(new Config() { Key = key });
            }
        }

        public string Get(string key)
        {
            using (var context = new ConfigContext(DbPath))
            {
                return context.Configs.Find(key)?.Value;
            }
        }

        public bool Save(string key, string value)
        {
            using (var context = new ConfigContext(DbPath))
            {
                return context.Configs.Update(new Config() { Key = key, Value = value }) != null;
            }
        }
    }
}
