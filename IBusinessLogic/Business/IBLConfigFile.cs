using System;

namespace IBusinessLogic
{
    public interface IBLConfigFile
    {
        string PIN { get; set; }
        bool CheckPIN(string pin);
        void Clear();
    }
}
