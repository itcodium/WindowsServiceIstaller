using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration.Install;
using System.ServiceProcess;
using System.ComponentModel;

namespace NewsServiceCaller
{   [RunInstaller(true)]
   public class NewsCallerInstaller: Installer
   {
    
    public NewsCallerInstaller() {
        ServiceProcessInstaller spi = new ServiceProcessInstaller();
        ServiceInstaller si = new ServiceInstaller();
        
        spi.Account = ServiceAccount.LocalSystem;
        spi.Username = null;
        spi.Password = null;

        si.DisplayName = "News Caller 07";
        si.StartType = ServiceStartMode.Automatic;
        si.ServiceName = "News Caller 07";
        this.Installers.Add(spi);
        this.Installers.Add(si);
    }

    private void InitializeComponent()
    {

    }
    

    }
}
