using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.ServiceModel;
using Newtonsoft.Json.Linq;

namespace Wcf_WS
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service1 : IService1
    {
        static Action<string, string, string> getStation_event = delegate { };
        static Action getStation2_event = delegate { };
        private static string cities = "";
        private static string stations = "";

        public void SubscribedGetVelibEvent()
        {
            Interface1 subscriber = OperationContext.Current.GetCallbackChannel<Interface1>();
            getStation_event += subscriber.getTheVelibInStation;
        }

        public void SusbcribedGetVelibFinishedEvent()
        {
            Interface1 subscriber = OperationContext.Current.GetCallbackChannel<Interface1>();
            getStation2_event += subscriber.getTheVelibFinished;
        }


        public string GetStation (string apiKey, string city)
        {
            if (stations.Length > 0)
            {
                return stations;
            }
            else
            {
                string requestText = "https://api.jcdecaux.com/vls/v1/stations?contract=" + city + "&apiKey=" + apiKey;
                WebRequest request = WebRequest.Create(requestText);
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();

                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                string responseText = reader.ReadToEnd();
                reader.Close();
                response.Close();

                JArray j = JArray.Parse(responseText);
                stations = j.ToString();
                return stations;
            }
        }

        public void GetBike(string numberToFind, string ville)
        {
            string apiKey = "4bbc90a044777223331b17076a335ddf48da0197";
            string jText = GetStation(apiKey, ville);
            JArray j = JArray.Parse(jText);
            string station = null;
            int numberOfBikes = 0;
            foreach (JObject item in j)
            {
                string name = (string)item.SelectToken("name");

                if (name.Contains(numberToFind))
                {
                    numberOfBikes = (int)item.SelectToken("available_bikes");
                    station = name;
                    break;
                }
            }
            getStation_event(ville, station, numberOfBikes.ToString());
            getStation2_event();
        }
    }
}
