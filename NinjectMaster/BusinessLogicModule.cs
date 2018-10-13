using BusinessLogic;
using IBusinessLogic;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace NinjectMaster
{
    public class BusinessLogicModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBLConfigFile>().To<BLConfigFile>().InSingletonScope();
        }
    }
}
