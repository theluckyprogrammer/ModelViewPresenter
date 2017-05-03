using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters;
using Contracts;

namespace LoggingPresenter2
{
    public class LoggingPresenter  : MainPresenter
    {
        string logPath = string.Concat(Environment.CurrentDirectory, '\\', "extraActionLog.txt");
      
        public LoggingPresenter(IMainView view): base(view)
        {

        }

        protected override void DoExtraAction(string action)
        {
            File.AppendAllText(logPath, DateTime.Now.ToString("dd MMM HH mm ss") + " " + action + " started" + Environment.NewLine);            
        }
    }
}
