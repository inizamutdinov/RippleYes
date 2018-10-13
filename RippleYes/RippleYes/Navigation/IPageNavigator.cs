using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RippleYes
{
    public interface IPageNavigator
    {
        void ToCreatePINPage(INavigation navigation);
        void ToLoginPINPage(INavigation navigation);
        void ToWalletsPage(INavigation navigation);
        void ToAddWalletPage(INavigation navigation);
        void ToShowWalletInfoPage(INavigation navigation, string address);
    }
}
