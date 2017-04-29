using Contracts;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.Configuration;

namespace LoggingPresenters
{
    public class LoggingPresenter : IMainPresenter
    {
        IMainView view;        
        static UnityContainer container;
        string logPath = string.Concat(Environment.CurrentDirectory, '\\', "log.txt");

        public static UnityContainer Container
        {
            get
            {
                if (container == null)
                {
                    container = new UnityContainer();
                    container.LoadConfiguration();
                }
                return container;
            }

            set
            {
                container = value;
            }
        }

        public LoggingPresenter(IMainView view)
        {
            this.view = view;
        }

        public void AddCustomer()
        {
            File.AppendAllText(logPath, DateTime.Now.ToString("dd MMM HH mm ss") +  " Add customer started" + Environment.NewLine);
            Container.Resolve<IMainPresenter>("default", new ParameterOverride("view", view)).AddCustomer();
        }

        public void EditCustomer()
        {
            File.AppendAllText(logPath, DateTime.Now.ToString("dd MMM HH mm ss") + " Edit customer started" + Environment.NewLine);
            Container.Resolve<IMainPresenter>("default", new ParameterOverride("view", view)).EditCustomer();
        }

        public void DeleteCustomer()
        {
            File.AppendAllText(logPath, DateTime.Now.ToString("dd MMM HH mm ss") + " Delete customer started" + Environment.NewLine);
            Container.Resolve<IMainPresenter>("default", new ParameterOverride("view", view)).DeleteCustomer();
        }

        public void LoadInitialData()
        {
            File.AppendAllText(logPath, DateTime.Now.ToString("dd MMM HH mm ss") + " Initial load started" + Environment.NewLine);
            Container.Resolve<IMainPresenter>("default", new ParameterOverride("view", view)).LoadInitialData();
        }

        public void CustomerSearch()
        {
            File.AppendAllText(logPath, DateTime.Now.ToString("dd MMM HH mm ss") + " search started" + Environment.NewLine);
            Container.Resolve<IMainPresenter>("default", new ParameterOverride("view", view)).CustomerSearch();
        }
    }
}
