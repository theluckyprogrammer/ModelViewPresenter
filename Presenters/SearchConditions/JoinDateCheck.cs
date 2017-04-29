using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.SearchConditions
{
    public class JoinDateCheck : ICheck
    {
        DateTime joinDate;

        public JoinDateCheck(DateTime joinDate)
        {
            this.joinDate = joinDate;
        }

        public bool Check(Customer customer)
        {
            if (joinDate == null)
                return true;
            return customer.JoinDate == joinDate;
        }
    }
}
