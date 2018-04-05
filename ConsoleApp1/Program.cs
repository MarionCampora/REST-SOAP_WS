using Newtonsoft.Json.Linq;
using System;
using System.ServiceModel;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcServiceCallbackSink objsink = new CalcServiceCallbackSink();
            InstanceContext iCntxt = new InstanceContext(objsink);

            VelibReference1.Service1Client objClient = new VelibReference1.Service1Client(iCntxt);
            objClient.SubscribedGetVelibEvent ();
            objClient.SusbcribedGetVelibFinishedEvent();

            string ville = "Toulouse";
            string station = "FEUGA";

            objClient.GetBike(ville,station);

            Console.ReadLine();

        }
    }
}
