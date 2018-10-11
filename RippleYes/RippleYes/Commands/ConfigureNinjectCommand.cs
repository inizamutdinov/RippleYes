using Ninject;
using NinjectMaster;
using System;
using System.Collections.Generic;
using System.Text;

namespace RippleYes.Commands
{
    public class ConfigureNinjectCommand
    {
        public ConfigureNinjectCommand(string dbPath)
        {
            DbPath = dbPath ?? throw new ArgumentNullException(nameof(dbPath));
        }

        private readonly string DbPath;

        public void Execute()
        {
            var settings = new Ninject.NinjectSettings() { LoadExtensions = false };
            App.Kernel = new StandardKernel(settings);
            App.Kernel.Load(new RepositoryModule(DbPath));
            App.Kernel.Bind<IStoryFile>().To<StoryFile>().InSingletonScope();
            App.Kernel.Bind<ISmartNavigator>().To<SmartNavigator>().InSingletonScope();
        }
    }
}
