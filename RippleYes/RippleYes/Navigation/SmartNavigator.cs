using IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RippleYes
{
    internal class SmartNavigator : ISmartNavigator
    {
        public void CheckEmail(INavigation navigation, IStoryFile storyFile)
        {
            if (string.IsNullOrEmpty(storyFile.Email))
            {
                navigation.PushModalAsync(new Pages.InputEmailPage());
            }
        }
    }
}
