using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CalcServiceCallbackSink : VelibReference1.IService1Callback
    {
        public void getTheVelibFinished()
        {
            Console.WriteLine("C'est fini");
        }

        public void getTheVelibInStation(string city, string station, string result)
        {
            Console.WriteLine("A " + city);
            Console.WriteLine("A la station " + station);
            Console.WriteLine("Il y a " + result + " vélos.");
        }
    }
}
