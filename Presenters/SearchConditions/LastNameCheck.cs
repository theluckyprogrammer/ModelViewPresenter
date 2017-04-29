using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.SearchConditions
{
    public class LastNameCheck : ICheck
    {
        string lastName;

        public LastNameCheck(string lastName)
        {
            this.lastName = lastName;
        }

        public bool Check(Customer customer)
        {
            if (string.IsNullOrEmpty(lastName))
                return true;
            return customer.LastName.Contains(lastName);
        }
    }
}
