using IBusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace RippleYes.MicroCommands
{
    public class ApplyNewPINCommand
    {
        public ApplyNewPINCommand(IBLConfigFile configFile, string newPIN)
        {
            NewPIN = newPIN;
            ConfigFile = configFile;
        }

        private readonly string NewPIN;
        private readonly IBLConfigFile ConfigFile;

        public void Execute()
        {
            ConfigFile.Clear();
            ConfigFile.PIN = NewPIN;
        }
    }
}
