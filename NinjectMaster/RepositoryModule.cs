using IRepository;
using IRepository.Migrator;
using Ninject.Modules;
using SQLiteRepository.Migrator;
using SQLiteRepository.Repositories;
using System;

namespace NinjectMaster
{
    public class RepositoryModule : NinjectModule
    {
        public RepositoryModule(string dbPath)
        {
            DbPath = dbPath ?? throw new ArgumentNullException(nameof(dbPath));
        }

        private readonly string DbPath;

        public override void Load()
        {
            Bind<IMigrator>().ToMethod(p => new SqliteMigrator(DbPath)).InSingletonScope();
            Bind<IConfigRepository>().ToMethod(p => new ConfigRepository(DbPath)).InSingletonScope();
        }
    }
}
