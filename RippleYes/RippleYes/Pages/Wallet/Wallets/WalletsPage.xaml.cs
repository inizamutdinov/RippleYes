using Ninject;
using RippleYes.Pages.Wallet.Wallets;
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
	public partial class WalletsPage : ContentPage
	{
		public WalletsPage ()
		{
			InitializeComponent ();
            BindingContext = new WalletsViewModel(Navigation,
                App.Kernel.Get<ISmartNavigator>(), App.Kernel.Get<IPageNavigator>());
        }

        protected override bool OnBackButtonPressed()
        {
            return false;
        }

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}