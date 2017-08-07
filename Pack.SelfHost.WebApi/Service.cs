using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace Pack.SelfHost.WebApi
{
    public class Service
    {
        private IDisposable Start { get; set; }
        
        public Service OnStart()
        {
            try
            {
                Console.WriteLine("Initializing routes...");
                this.Start = WebApp.Start<Startup>(url: string.Format("http://{0}:3001", Environment.MachineName));

                Console.WriteLine("Routes initialized!");
                Console.WriteLine("Type any to exit...");
                Console.ReadLine();

                return this;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void OnStop()
        {
            try
            {
                Console.WriteLine("Desposing Start...");
                if (this.Start != null)
                {
                    this.Start.Dispose();
                    Console.WriteLine("Object Start was cleaned.");
                    Console.WriteLine("Closing until 3 seconds remaning...");
                    System.Threading.Thread.Sleep(3000);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
