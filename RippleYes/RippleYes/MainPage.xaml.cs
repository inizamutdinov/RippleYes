using System;
using Xamarin.Forms;
using Flurl.Http;

namespace RippleYes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var d = await "https://data.ripple.com/v2/accounts/rEhRJFYxGAd7JZZnVE7N6x8jsoRXW43dEd".GetStringAsync();
            text.Text = d;
            
        }
    }
}
