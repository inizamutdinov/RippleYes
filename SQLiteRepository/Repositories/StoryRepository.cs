using IRepository;
using SQLiteRepository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteRepository.Repositories
{
    public class StoryRepository : RepositoryBase, IStoryRepository
    {
        public StoryRepository(string dbPath)
            : base(dbPath)
        {

        }

        public void Clear()
        {
            using (var context = new StoryContext(DbPath))
            {
                context.Items.RemoveRange(context.Items);
            }
        }

        public void Delete(string key)
        {
            using (var context = new StoryContext(DbPath))
            {
                context.Items.Remove(new StoryContextItem() { Key = key });
            }
        }

        public string Get(string key)
        {
            using (var context = new StoryContext(DbPath))
            {
                return context.Items.Find(key)?.Value;
            }
        }

        public bool Save(string key, string value)
        {
            using (var context = new StoryContext(DbPath))
            {
                var record = new StoryContextItem() { Key = key, Value = value };
                var exists = context.Items.Any(t => string.Equals(key, t.Key));

                if (exists)
                {
                    context.Items.Update(record);
                }
                else
                {
                    context.Items.Add(record);
                }

                return context.SaveChanges() > 0;
            }
        }
    }
}
