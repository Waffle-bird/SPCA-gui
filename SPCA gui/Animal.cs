using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPCA_gui
{
    public class Animal
    {
        //Object Properties
        private string name;
        private int animalAge;
        private string species;
        private Dictionary<DateTime, int> consumptions = new Dictionary<DateTime, int>();
        private int id;

        public Animal(string nme, int age, string spcs)
        {
            name = nme;
            animalAge = age;
            species = spcs;
        }


        public Dictionary<DateTime,int> GetConsumptions()
        {
            return consumptions;
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return animalAge;
        }

        public string GetSpecies()
        {
            return species;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void AddConsumption(DateTime date, int consumption)
        {           
            this.consumptions.Add(date, consumption);

            MessageBox.Show($"This animal has {consumptions.Count} recorded consumption(s)");
        }
        
        public int TotalConsumptions()
        {
            int totalConsumption = 0;

            foreach (KeyValuePair<DateTime, int> consumption in consumptions)
            {
                totalConsumption += consumption.Value;
            }

            return totalConsumption;
        }
    }
}
