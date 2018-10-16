using Flurl.Http;
using RippleYes.Pages.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RippleYes.Pages.Wallet.WalletInfo
{
    public class WalletInfoViewModel : ViewModelBase
    {
        public WalletInfoViewModel(INavigation navigation, ISmartNavigator smartNavigator, IPageNavigator pageNavigator,
            string address)
            : base(navigation, smartNavigator, pageNavigator)
        {
            Address = address;
        }

        public string Address { get; }

        public string Info
        {
            get { return _info; }
            set { Set(ref _info, value); }
        }
        private string _info;

        internal async void LazyLoadWalletInfo()
        {
            Info = await $"https://data.ripple.com/v2/accounts/{Address}".GetStringAsync();
        }
    }
}
