using IBusinessLogic;
using Ninject;
using RippleYes.Pages.Login.CreationPIN;
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
    public partial class CreatePINPage : ContentPage
    {
        public CreatePINPage()
        {
            InitializeComponent();
            BindingContext = new CreatePINViewModel(Navigation, 
                App.Kernel.Get<ISmartNavigator>(), App.Kernel.Get<IPageNavigator>(), App.Kernel.Get<IBLConfigFile>());
        }

        protected override bool OnBackButtonPressed()
        {
            return false;
        }
    }
}