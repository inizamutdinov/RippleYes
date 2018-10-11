using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RippleYes.UWP
{
    public class WinPath : IOSPath
    {
        public string DbFolder => Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
    }
}
