using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ninject;
using Ninject.Web;

namespace NinjectWebFormsExample
{
    public partial class About : Page
    {
        [Inject]
        public ICustomerRepository CustomerRepo { get; set; }
        
        public About()
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var customer = CustomerRepo.GetCustomerFor(1);
            this.CustomerName.InnerText = customer.Name;

        }
    }
}