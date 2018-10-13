using Ninject;
using RippleYes.Pages.Wallet.WalletInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RippleYes.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WalletInfoPage : ContentPage
	{
		public WalletInfoPage (string address)
		{
			InitializeComponent ();
            BindingContext = new WalletInfoViewModel(Navigation, App.Kernel.Get<ISmartNavigator>(), App.Kernel.Get<PageNavigator>(), address);
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((WalletInfoViewModel)BindingContext).LazeLoadWalletInfo();
        }
    }
}