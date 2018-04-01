using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string> cities = new List<string>();
        private List<string> stations = new List<string>();
        Service1Client client = new Service1Client();
        string ville = null;
        string apiKey = "4bbc90a044777223331b17076a335ddf48da0197";

        public Form1()
        {
            InitializeComponent();
            string k = client.GetCity(apiKey);
            JArray kArray = JArray.Parse(k);

            foreach (JObject item in kArray)
            {
                string name = (string)item.SelectToken("name");
                cities.Add(name);
            } 
            comboBox1.Items.AddRange(cities.ToArray());
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string j = null;
            ville = comboBox1.SelectedItem as string;
            j = client.GetStation(apiKey, ville);
            JArray jArray = JArray.Parse(j);
            foreach (JObject item in jArray)
            {
                string name = (string)item.SelectToken("name");
                stations.Add(name);
            }
            comboBox2.Items.AddRange(stations.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string station = comboBox2.SelectedItem as string;
            label3.Text = "Il y a " + client.GetBike(apiKey, station, ville) + " vélos à la station " + station;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "Choisissez une ville et appuyez sur le bouton validez.\n" +
                "Puis choississez une station et appuyez sur le deuxième bouton validez,\n" +
                "le nombre de vélos disponnibles dans cette station s'affiche alors.";
        }
    }
}
