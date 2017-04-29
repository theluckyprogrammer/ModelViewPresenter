using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.SearchConditions
{
    public class FirstNameCheck : ICheck
    {
        string firstName;

        public FirstNameCheck(string firstName)
        {
            this.firstName = firstName;
        }

        public bool Check(Customer customer)
        {
            if (string.IsNullOrEmpty(firstName))
                return true;
            return customer.FirstName.Contains(firstName);
        }
    }
}
