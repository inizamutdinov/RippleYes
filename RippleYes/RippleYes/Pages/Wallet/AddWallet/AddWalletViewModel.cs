using RippleYes.Pages.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RippleYes.Pages.Wallet.AddWallet
{
    public class AddWalletViewModel : ViewModelBase
    {
        public AddWalletViewModel(INavigation navigation, ISmartNavigator smartNavigator, IPageNavigator pageNavigator)
            : base(navigation, smartNavigator, pageNavigator)
        {
            NextCommand = new Command(DoNext, CanNext);
        }

        public string Address
        {
            get { return _address; }
            set
            {
                Set(ref _address, value);
                ((Command)NextCommand).ChangeCanExecute();
            }
        }
        private string _address;

        public ICommand NextCommand { get; private set; }

        private void DoNext()
        {
            SmartNavigator.ShowWalletInfo(Navigation, PageNavigator, Address);
        }

        private bool CanNext()
        {
            return _address?.Length >= 25 && _address?.Length <= 35 && _address[0] == 'r';
        }
    }
}
