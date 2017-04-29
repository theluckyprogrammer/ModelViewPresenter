using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMainPresenter
    {
        void AddCustomer();
        void EditCustomer();
        void DeleteCustomer();
        void LoadInitialData();
        void CustomerSearch();
    }
}
