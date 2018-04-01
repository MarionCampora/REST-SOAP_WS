using Newtonsoft.Json.Linq;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string j = null;
            string apiKey = "4bbc90a044777223331b17076a335ddf48da0197";
            Service1Client client = new Service1Client();
            Console.WriteLine("Pour de l'aide, tapez \"help\"");
            bool stop = true;
            while (stop)
            {
                Console.WriteLine("Choisissez une ville :");
                string ville = Console.ReadLine();
                while (ville.Equals("help"))
                {
                    string k = client.GetCity(apiKey);

                    JArray kArray = JArray.Parse(k);
                    foreach (JObject item in kArray)
                    {
                        //Affichage du nom et numéro de toutes les stations
                        string name = (string)item.SelectToken("name");
                        Console.WriteLine(name);
                        //Attention on sort totalement ! On ne peut plus entrer de nom de station (d'où le help)
                    }
                    Console.WriteLine("Ecrivez le nom d'une des villes ci-dessus pour avoir accès à ses stations.");
                    ville = Console.ReadLine();
                }

                Console.WriteLine("Choisissez une station : ");
                string station = Console.ReadLine();

                j = client.GetStation(apiKey, ville); //C'est trop gros, on peut pas recevoir des messages aussi gros.

                while (station.Equals("help"))
                {
                    JArray jArray = JArray.Parse(j);
                    foreach (JObject item in jArray)
                    {
                        //Affichage du nom et numéro de toutes les stations
                        string name = (string)item.SelectToken("name");
                        Console.WriteLine(name);
                    }
                    Console.WriteLine("Ecrivez le nom d'une des stations ci-dessus pour obtenir le nombre de vélos");
                    station = Console.ReadLine();
                }
                Console.WriteLine("Il y a " + client.GetBike(apiKey, station, ville) + " vélos dans la station " + station);
                Console.WriteLine("Voulez-vous continuer ? (y\\n)");
                string continu = Console.ReadLine();
                if (continu.Equals("n"))
                {
                    stop = false;
                }
            }
            

            client.Close();
        }
    }
}
