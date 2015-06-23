using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
 

namespace WebPageCaller
{
    public class CallPage
    {
        string url = System.Configuration.ConfigurationManager.AppSettings["url"];

        WebClient client = new WebClient();
        string downloadString ="";
        public CallPage() {
            
        }
        public void getPage() {
            downloadString = client.DownloadString(url);
        }
    }
}

 