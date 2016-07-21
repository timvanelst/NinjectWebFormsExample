using Ninject;
using Ninject.Web;
using NinjectWebFormsExample;

namespace Company.Web
{
    public class YourWebModule : Ninject.Modules.NinjectModule
    {

        public override void Load()
        {
            Bind<ICustomerRepository>().To<CustomerRepository>();
        }
    }
}