using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RippleYes.MicroCommands
{
    public class OSPathCommand
    {
        public OSPathCommand(IOSPath osPath)
        {
            OSPath = osPath ?? throw new ArgumentNullException(nameof(osPath));
        }

        private readonly IOSPath OSPath;
        private readonly string DbFileName = "rippleyes.db3";

        public string Execute()
        {
            return Path.Combine(OSPath.DbFolder, DbFileName);
        }
    }
}
