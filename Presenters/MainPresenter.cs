﻿using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Contracts.ViewExtenders;
using Presenters.SearchConditions;

namespace Presenters
{
    public class MainPresenter : BasePresenter, IMainPresenter
    {
        IMainView view;

        public MainPresenter(IMainView view)
        {
            this.view = view;
        }

        public virtual void AddCustomer()
        {
            DoExtraAction("AddCustomer");
            var customer = view.ToCustomer();
            customer = database.Customers.Add(customer);
            database.SaveChanges();
            view.Customers = database.Customers.ToList();
        }

        public virtual void DeleteCustomer()
        {
            DoExtraAction("DeleteCustomer");
            int customerId = view.ToCustomer().CustomerID;
            var customer = database.Customers.Single(c => c.CustomerID == customerId);
            database.Customers.Remove(customer);
            database.SaveChanges();
            view.Customers = database.Customers.ToList();
        }

        public virtual void EditCustomer()
        {
            DoExtraAction("EditCustomer");
            var customer = view.ToCustomer();
            database.Entry<Customer>(customer).State = System.Data.Entity.EntityState.Modified;
            database.SaveChanges();
            view.Customers = database.Customers.ToList();
        }

        public virtual void LoadInitialData()
        {
            DoExtraAction("LoadInitialData");
            view.Customers = database.Customers.ToList();
        }

        public virtual void CustomerSearch()
        {
            DoExtraAction("CustomerSearch");
            var customer = view.ToCustomer();
            Search search = new Search(new LastNameCheck(customer.LastName), new FirstNameCheck(customer.FirstName));
            view.Customers = database.Customers.ToList().Where(c => search.Check(c)).ToList();

        }

        protected virtual void DoExtraAction(string action)
        {
            return;
        }
    }
}
