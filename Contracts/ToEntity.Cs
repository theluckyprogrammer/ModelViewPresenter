using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ViewExtenders
{
    public static class ToEntity
    {
        public static Customer ToCustomer(this IMainView view)
        {
            return new Customer { FirstName = view.FirstName, JoinDate = view.JoinDate, LastName = view.LastName, CustomerID = view.CustomerID, Address = view.Address };
        }
    }
}
