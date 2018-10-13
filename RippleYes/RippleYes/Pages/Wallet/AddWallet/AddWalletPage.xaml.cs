using Ninject;
using RippleYes.Pages.Wallet.AddWallet;
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
	public partial class AddWalletPage : ContentPage
	{
		public AddWalletPage ()
		{
			InitializeComponent ();
            BindingContext = new AddWalletViewModel(Navigation, App.Kernel.Get<ISmartNavigator>(), App.Kernel.Get<IPageNavigator>());
		}
	}
}