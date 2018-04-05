using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EventHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                ServiceHost host = new ServiceHost(typeof(Wcf_WS.Service1));
                host.Open();
                Console.WriteLine("Service is Hosted as http://localhost:8733/VelibService");
                Console.WriteLine("\nPress  key to stop the service.");
                Console.ReadLine();
                host.Close();
            }
            catch (Exception eX)
            {
                Console.WriteLine("There was en error while Hosting Service [" + eX.Message + "]");
                Console.WriteLine("\nPress  key to close.");
                Console.ReadLine();
            }
        }
    }
}
