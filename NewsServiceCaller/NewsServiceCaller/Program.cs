using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace NewsServiceCaller
{

    // http://milindapro.blogspot.com.ar/2012/07/create-window-service-project-in-c-part.html
    // http://milindapro.blogspot.com.ar/2012/07/create-window-service-project-in-c-part_11.html
    // http://milindapro.blogspot.com.ar/2012/07/create-window-service-project-in-c-part_16.html

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new Service1() 
			};
            ServiceBase.Run(ServicesToRun);
        }
    }
}
