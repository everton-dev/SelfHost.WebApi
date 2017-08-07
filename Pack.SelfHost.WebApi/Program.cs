using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Pack.SelfHost.WebApi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            new Pack.SelfHost.WebApi.Service().OnStart().OnStop();
        }
    }
}
