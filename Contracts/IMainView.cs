using System;
using System.Collections.Generic;
using Contracts;

namespace Contracts
{
    public interface IMainView
    {
        string Address { get; set; }
        List<Customer> Customers { get; set; }
        string FirstName { get; set; }
        DateTime JoinDate { get; set; }
        string LastName { get; set; }
        int CustomerID { get; set; }
    }
}