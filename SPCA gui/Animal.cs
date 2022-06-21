using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCA_gui
{
    public class Animal
    {
        //Object Properties
        private string name;
        private int animalAge;
        private string species;
        private List<int> consumptions = new List<int>();

        public Animal(string nme, int age, string spcs)
        {
            name = nme;
            animalAge = age;
            species = spcs;
        }


        public List<int> GetConsumptions()
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
    }
}
