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
