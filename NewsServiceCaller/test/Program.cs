using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            WebPageCaller.CallPage c = new WebPageCaller.CallPage();
            c.getPage();
        }
    }
}
