using Contracts;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity.Configuration;

namespace CustomersRegistry
{
    public partial class MainForm : Form, IMainView
    {
        UnityContainer unityContainer;
        ParameterOverride thisForm;
        MainViewState mainViewState;         

        public string FirstName
        {
            get { return FirstNameTbx.Text; }
            set { FirstNameTbx.Text = value; }
        }
        public string LastName
        {
            get { return LastNameTbx.Text; }
            set { LastNameTbx.Text = value; }
        }

        public string Address
        {
            get { return AddressTbx.Text; }
            set { AddressTbx.Text = value; }
        }

        public DateTime JoinDate
        {
            get { return JoinDatePicker.Value; }
            set { JoinDatePicker.Text = value.ToString(); }
        }

        private List<Customer> customers;
        public List<Customer> Customers
        {
            get { return customers; }
            set { customers = value;
                MainDataGrid.DataSource = value;
                MainDataGrid.Refresh();
            }
        }

        public int CustomerID { get; set; }
       

        public MainForm()
        {           
            InitializeComponent();
            unityContainer = new UnityContainer();
            unityContainer.LoadConfiguration();
            thisForm = new ParameterOverride("view", this);
            unityContainer.Resolve<IMainPresenter>(thisForm).LoadInitialData();
        }   

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchView(MainViewState.AddCustomer);                    
        }

        private void EditCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchView(MainViewState.EditCustomer);
        }

        private void DeleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unityContainer.Resolve<IMainPresenter>(thisForm).DeleteCustomer();
        }

        private void SearchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchView(MainViewState.EditCustomer);
        }
      
        protected void SwitchView(MainViewState state)
        {
            mainViewState = state;
            switch (state)
            {
                case MainViewState.AddCustomer:
                    ResetViewCustomer();
                    CustomerPanel.Visible = true;
                    GridPanel.Visible = false;
                    break;
                case MainViewState.EditCustomer:
                    CustomerPanel.Visible = true;
                    GridPanel.Visible = false;
                    break;
                case MainViewState.Grid:
                    CustomerPanel.Visible = false;
                    GridPanel.Visible = true;
                    break;
                case MainViewState.SearchCustomer:
                    ResetViewCustomer();
                    CustomerPanel.Visible = true;
                    GridPanel.Visible = false;
                    break;
                default:
                    throw new IndexOutOfRangeException("Nie zaimplementowana wartość operatora");

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var presenter = unityContainer.Resolve<IMainPresenter>(thisForm);
            switch (mainViewState)
            {
                case MainViewState.AddCustomer:                   
                    presenter.AddCustomer();
                    break;

                case MainViewState.EditCustomer:
                    presenter.EditCustomer();
                    break;

                default:
                    throw new IndexOutOfRangeException("Nie zaimplementowana wartość operatora");
            }

            SwitchView(MainViewState.Grid);
        }

        private void MainDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (MainDataGrid.SelectedRows.Count == 0)
                return;

            var customer = MainDataGrid.SelectedRows[0].DataBoundItem as Customer;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Address = customer.Address;
            JoinDate = customer.JoinDate;
            CustomerID = customer.CustomerID;
        }

        private void ResetViewCustomer()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Address = string.Empty;
            JoinDate = DateTime.Now;
            CustomerID = 0;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            SwitchView(MainViewState.Grid);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            unityContainer.Resolve<IMainPresenter>(thisForm).CustomerSearch();
            SwitchView(MainViewState.Grid);
        }      
    }
}
