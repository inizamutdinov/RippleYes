using IRepository;
using IRepository.Migrator;
using Ninject;
using NinjectMaster;
using RippleYes.Commands;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace RippleYes
{
    public partial class App : Application
    {
        public App(IOSPath osPath)
        {
            InitializeComponent();

            OSPath = osPath;
            MainPage = new MainPage();
        }

        private readonly IOSPath OSPath;
        internal static IKernel Kernel = null;

        protected override void OnStart()
        {
            // Handle when your app starts
            ConfigureNinject();
            Migrate();
            Kernel.Get<ISmartNavigator>().CheckEmail(MainPage.Navigation, Kernel.Get<IStoryFile>());
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void ConfigureNinject()
        {
            new ConfigureNinjectCommand(GetDbPath()).Execute();
        }

        private void Migrate()
        {
            new MigrationCommand(Kernel.Get<IMigrator>()).Execute();
        }

        private string GetDbPath()
        {
            return new OSPathCommand(OSPath).Execute();
        }
    }
}
