using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RippleYes
{
    public class PageNavigator : IPageNavigator
    {
        public void ToCreatePINPage(INavigation navigation)
        {
            navigation.PushModalAsync(new Pages.CreatePINPage());
        }

        public void ToLoginPINPage(INavigation navigation)
        {
            navigation.PushModalAsync(new Pages.LoginPINPage());
        }

        public void ToWalletsPage(INavigation navigation)
        {
            App.Current.MainPage = new NavigationPage(new Pages.WalletsPage());
        }

        public void ToAddWalletPage(INavigation navigation)
        {
            navigation.PushAsync(new Pages.AddWalletPage());
        }

        public void ToShowWalletInfoPage(INavigation navigation, string address)
        {
            navigation.PushAsync(new Pages.WalletInfoPage(address));
        }
    }
}
