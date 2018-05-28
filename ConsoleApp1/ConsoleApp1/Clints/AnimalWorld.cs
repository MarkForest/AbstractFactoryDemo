using ConsoleApp1.Factories;
using ConsoleApp1.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clints
{
    public class AnimalWorld
    {
        private Herbivore herbivore;
        private Carnivore carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            herbivore = factory.CreateHerbivore();
            carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }
}
