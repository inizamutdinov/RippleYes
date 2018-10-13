using IBusinessLogic;
using RippleYes.Pages.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RippleYes.Pages.Login.CreationPIN
{
    public class CreatePINViewModel : ViewModelBase
    {
        public CreatePINViewModel(INavigation navigation, ISmartNavigator smartNavigator, IPageNavigator pageNavigation,
            IBLConfigFile configFile)
            : base(navigation, smartNavigator, pageNavigation)
        {
            ConfigFile = configFile;
            NextCommand = new Command(DoNext, CanDoNext);
        }

        private readonly IBLConfigFile ConfigFile;
        private const int PinLength = 4;

        public string PIN
        {
            get { return _pin; }
            set
            {
                if (value?.Length > PinLength)
                {
                    NotifyPropertyChanged(nameof(PIN));
                }
                else
                {
                    Set(ref _pin, value);
                    ((Command)NextCommand).ChangeCanExecute();
                }
            }
        }
        private string _pin;

        public ICommand NextCommand { get; private set; }

        private void DoNext()
        {
            SmartNavigator.ApplyNewPIN(Navigation, PageNavigator, ConfigFile, PIN);
        }

        private bool CanDoNext() => PIN?.Length == PinLength;
    }
}
