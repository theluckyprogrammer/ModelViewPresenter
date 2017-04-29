using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.SearchConditions
{
    public class AddressCheck : ICheck
    {
        string address;

        public AddressCheck(string address)
        {
            this.address = address;
        }

        public bool Check(Customer customer)
        {
            if (string.IsNullOrEmpty(address))
                return true;
            return customer.Address == address;
        }
    }
}
