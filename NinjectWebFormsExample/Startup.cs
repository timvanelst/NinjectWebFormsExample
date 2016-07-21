using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NinjectWebFormsExample.Startup))]
namespace NinjectWebFormsExample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
