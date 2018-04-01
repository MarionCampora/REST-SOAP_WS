using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Wcf_WS
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service1 : IService1
    {
        private static string cities = "";
        private static string stations = "";

        public string GetCity(string apiKey)
        {
            if (cities.Length > 0)
            {
                return cities;
            }
            else
            {
                string requestText = "https://api.jcdecaux.com/vls/v1/contracts/?apiKey=" + apiKey;
                WebRequest request = WebRequest.Create(requestText);
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                cities = reader.ReadToEnd();
                reader.Close();
                response.Close();
                return cities;
            }
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

        public int GetBike(string apiKey, string numberToFind, string ville)
        {
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
            return numberOfBikes;
        }
    }
}
