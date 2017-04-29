using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.Configuration;

namespace Presenters
{
    public class BasePresenter
    {
        private static IUnityContainer unity;
        private static string connectionString = @"Data Source = Database.sdf;Password=kolega";
        protected MyDatabase database; // i don't consider changing database access class in future
              
        protected IUnityContainer UnityContainer
        {
            get { return unity; }
            private set { }
        }
        
        public BasePresenter()
        {
            if (unity == null)
            {
                unity = new UnityContainer();
                unity.LoadConfiguration();
                unity.RegisterType(typeof(MyDatabase), typeof(MyDatabase),
                new InjectionConstructor(connectionString)
                );
            }

            database = unity.Resolve<MyDatabase>();
        }
    }
}
