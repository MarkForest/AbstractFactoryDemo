using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Products;

namespace ConsoleApp1.Factories
{
    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
