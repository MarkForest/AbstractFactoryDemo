using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Products;

namespace ConsoleApp1.Factories
{
    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
