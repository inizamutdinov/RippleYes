using RippleYes.Pages.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RippleYes.Pages.Wallet.Wallets
{
    public class WalletsViewModel : ViewModelBase
    {
        public WalletsViewModel(INavigation navigation, ISmartNavigator smartNavigator, IPageNavigator pageNavigation)
            : base(navigation, smartNavigator, pageNavigation)
        {
            AddWalletCommand = new Command(DoAddWallet);
        }

        public ICommand AddWalletCommand { get; }

        private void DoAddWallet()
        {
            SmartNavigator.AddWallet(Navigation, PageNavigator);
        }
    }
}
