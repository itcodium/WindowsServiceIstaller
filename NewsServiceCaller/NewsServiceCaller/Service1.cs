using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using WebPageCaller;
namespace NewsServiceCaller
{
    public partial class Service1 : ServiceBase
    {
        System.Timers.Timer tmrDelay;
        int count;

        public Service1()
        {
            string strSource = "NewsSrc7";
            string strLog = "NewsLog7";
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists(strSource))
            {
                System.Diagnostics.EventLog.CreateEventSource(strSource, strLog);
            }

            //set our event log to system created log
            NewsCallerLog.Source = strSource;
            NewsCallerLog.Log = strLog; //Nombre del log

            int executionTime = Convert.ToInt32( System.Configuration.ConfigurationManager.AppSettings["ExecutionTime"]);

            tmrDelay = new System.Timers.Timer(executionTime);
            tmrDelay.Elapsed += new System.Timers.ElapsedEventHandler(tmrDelay_Elapsed);
    
        }

        protected override void OnStart(string[] args)
        {
            NewsCallerLog.WriteEntry("News Caller start");
            tmrDelay.Enabled = true;
        }

        protected override void OnStop()
        {
            NewsCallerLog.WriteEntry("News Caller stoped");
            tmrDelay.Enabled = false;
        }
        void tmrDelay_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string str = "Timer tick " + count;
            NewsCallerLog.WriteEntry(str);
            count++;
            CallPage cp = new CallPage();
            cp.getPage();
        }
    }
}
