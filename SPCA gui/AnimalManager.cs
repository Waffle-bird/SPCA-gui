using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCA_gui
{
    public class AnimalManager
    {
        private List<Animal> animals = new List<Animal>();
        private int nextId = 1;

        public AnimalManager()
        {

        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }

        public int FindAnimal(int id)
        {
            int index = 0;
            foreach (Animal animal in animals)
            {
                if (animal.GetId() == id)
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public string AnimalSummary(int id)
        {
            string Summary = $"Total consumption weight to date: {animals[FindAnimal(id)].TotalConsumptions()}g\n";

            return Summary;
        }

        public string AllAnimalsCostSummary()
        {
            string Summary = $"Total Food Cost: ${AllAnimalsCostTotal()}";

            return Summary;
        }

        public float AllAnimalsCostTotal()
        {
            float totalCost = 0;
            const float FOODCOST = 0.063f;

            foreach (Animal animal in animals)
            {
                foreach (KeyValuePair<DateTime, int> consumption in animal.GetConsumptions())
                {
                    totalCost += consumption.Value*FOODCOST;
                }
            }

            totalCost = (float)Math.Round(totalCost, 2);

            return totalCost;
        }

        public void AddConsumption(int id, DateTime date, int consumption)
        {
            int animalIndex = FindAnimal(id);

            if (animalIndex > -1)
            {
                animals[animalIndex].AddConsumption(date, consumption);
            }
        }

        public void AddOneAnimal(Animal newAnimal)
        {
            animals.Add(newAnimal);

            animals[animals.Count - 1].SetId(nextId);
            this.nextId += 1;

        }

        public string AnimalInfo()
        {
            return animals[animals.Count - 1].GetName() + " " + $"{animals[animals.Count - 1].GetAge()}" + " " + animals[animals.Count-1].GetSpecies();
        }

    }
}
