using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RippleYes.Pages.Base
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        protected ViewModelBase(INavigation navigation, ISmartNavigator smartNavigator, IPageNavigator pageNavigation)
        {
            Navigation = navigation;
            SmartNavigator = smartNavigator;
            PageNavigator = pageNavigation;
        }

        public bool IsChanged
        {
            get { return _isChanged; }
            set { Set(ref _isChanged, value); }
        }
        private bool _isChanged;
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler Changed;

        public INavigation Navigation { get; }
        public ISmartNavigator SmartNavigator { get; }
        public IPageNavigator PageNavigator { get; }

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if (propertyName == nameof(IsChanged))
            {
                Changed?.Invoke(this, EventArgs.Empty);
            }
        }

        protected bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (!object.Equals(field, value))
            {
                field = value;
                NotifyPropertyChanged(propertyName);
                if (propertyName != nameof(IsChanged))
                {
                    IsChanged = true;
                }

                return true;
            }

            return false;
        }

        public void WireEvents(Page page)
        {
            page.Appearing += ViewIsAppearing;
            page.Disappearing += ViewIsDisappearing;
        }
        protected virtual void ViewIsDisappearing(object sender, EventArgs e)
        {
        }

        protected virtual void ViewIsAppearing(object sender, EventArgs e)
        {
        }

        protected virtual async Task PushPage(ContentPage page)
        {
            await Navigation.PushAsync(page);
        }

        protected virtual async Task PushModelPage(ContentPage page)
        {
            await Navigation.PushModalAsync(page);
        }

        protected virtual async Task PopPage()
        {
            await Navigation.PopAsync();
        }
    }
}
