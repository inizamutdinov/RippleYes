using IBusinessLogic;
using IRepository;
using RippleYes.MicroCommands;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RippleYes
{
    internal class SmartNavigator : ISmartNavigator
    {
        public void ExistsPIN(INavigation navigation, IPageNavigator pageNavigator, IBLConfigFile configFile)
        {
            if (string.IsNullOrEmpty(configFile.PIN))
            {
                pageNavigator.ToCreatePINPage(navigation);
            }
            else
            {
                pageNavigator.ToLoginPINPage(navigation);
            }
        }

        public void ApplyNewPIN(INavigation navigation, IPageNavigator pageNavigator, IBLConfigFile configFile, string newPIN)
        {
            if (string.IsNullOrEmpty(newPIN))
            {
                throw new ArgumentNullException(nameof(newPIN));
            }

            new ApplyNewPINCommand(configFile, newPIN).Execute();

            pageNavigator.ToLoginPINPage(navigation);
        }

        public void Enter(INavigation navigation, IPageNavigator pageNavigator)
        {
            pageNavigator.ToWalletsPage(navigation);
        }

        public void AddWallet(INavigation navigation, IPageNavigator pageNavigator)
        {
            pageNavigator.ToAddWalletPage(navigation);
        }

        public void ShowWalletInfo(INavigation navigation, IPageNavigator pageNavigator, string address)
        {
            pageNavigator.ToShowWalletInfoPage(navigation, address);
        }
    }
}
