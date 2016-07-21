using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectWebFormsExample
{
    public interface ICustomerRepository
    {
        Customer GetCustomerFor(int customerID);
    }

    public class CustomerRepository : ICustomerRepository
    {
        #region ICustomerRepository Members

        public Customer GetCustomerFor(int customerID)
        {
            return new Customer 
            {
                Id = customerID,
                Name = string.Format("Klant {0}", customerID) 
            };
        }

        #endregion
    }

    public class BetterCustomerRepository : ICustomerRepository
    {
        #region ICustomerRepository Members

        public Customer GetCustomerFor(int customerID)
        {
            return new Customer
            {
                Id = customerID,
                Name = string.Format("Superklant {0}", customerID)
            };
        }

        #endregion
    }

}
