using IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RippleYes
{
    internal interface ISmartNavigator
    {
        void CheckEmail(INavigation navigation, IStoryFile storyFile);
    }
}
