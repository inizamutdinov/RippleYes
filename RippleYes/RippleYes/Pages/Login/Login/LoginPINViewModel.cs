using IBusinessLogic;
using RippleYes.Pages.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RippleYes.Pages.Login.Login
{
    public class LoginPINViewModel : ViewModelBase
    {
        public LoginPINViewModel(INavigation navigation, ISmartNavigator smartNavigator, IPageNavigator pageNavigation,
            IBLConfigFile configFile)
            : base(navigation, smartNavigator, pageNavigation)
        {
            ConfigFile = configFile;
            ForgotPINCommand = new Command(DoRestorePIN);
        }

        private readonly IBLConfigFile ConfigFile;
        private const int PINLENGTH = 4;

        public string PIN
        {
            get { return _pin; }
            set
            {
                if (value?.Length > PINLENGTH)
                {
                    NotifyPropertyChanged(nameof(PIN));
                }
                else
                {
                    Set(ref _pin, value);
                }

                if (_pin?.Length == PINLENGTH && ConfigFile.CheckPIN(PIN))
                {
                    SmartNavigator.Enter(Navigation, PageNavigator);
                }
            }
        }
        private string _pin;

        public ICommand ForgotPINCommand { get; private set; }

        private void DoRestorePIN()
        {
            PageNavigator.ToCreatePINPage(Navigation);
        }
    }
}
