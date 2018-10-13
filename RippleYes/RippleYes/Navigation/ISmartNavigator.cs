using IBusinessLogic;
using IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RippleYes
{
    public interface ISmartNavigator
    {
        void ExistsPIN(INavigation navigation, IPageNavigator pageNavigation, IBLConfigFile configFile);
        void ApplyNewPIN(INavigation navigation, IPageNavigator pageNavigation, IBLConfigFile configFile, string newPIN);
        void Enter(INavigation navigation, IPageNavigator pageNavigation);
        void AddWallet(INavigation navigation, IPageNavigator pageNavigation);
        void ShowWalletInfo(INavigation navigation, IPageNavigator pageNavigator, string address);
    }
}
