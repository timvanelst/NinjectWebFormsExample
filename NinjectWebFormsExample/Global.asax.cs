using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Company.Web;
using Ninject;
using Ninject.Web.Common;

namespace NinjectWebFormsExample
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //protected override IKernel CreateKernel()
        //{
        //    IKernel kernel = new StandardKernel(new YourWebModule());
        //    return kernel;
        //}
    }
}