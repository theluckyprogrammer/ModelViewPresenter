using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.SearchConditions
{
    class Search : ICheck
    {
        List<ICheck> checkers;

        public Search(params ICheck[] checkers)
        {
            this.checkers = checkers.ToList();
        }

        public bool Check(Customer customer)
        {
            if (checkers.Any(condition => !condition.Check(customer)))
                return false;

          return true;
        }
    }
}
