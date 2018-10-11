using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace RippleYes.iOS
{
    public class OSXPath : IOSPath
    {
        public string DbFolder => Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "..", "Library");
    }
}