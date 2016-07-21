using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;

namespace NinjectWebFormsExample.App_Start
{
    public static class NinjectBindings
    {

        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<ICustomerRepository>().To<BetterCustomerRepository>();
        }
    }
}