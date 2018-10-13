using IBusinessLogic;
using Ninject;
using RippleYes.Pages.Login.Login;
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
	public partial class LoginPINPage : ContentPage
	{
		public LoginPINPage ()
		{
			InitializeComponent();
            BindingContext = new LoginPINViewModel(Navigation,
                App.Kernel.Get<ISmartNavigator>(), App.Kernel.Get<IPageNavigator>(), App.Kernel.Get<IBLConfigFile>());
        }

        protected override bool OnBackButtonPressed()
        {
            return false;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            pinBox.Unfocus();
        }
    }
}