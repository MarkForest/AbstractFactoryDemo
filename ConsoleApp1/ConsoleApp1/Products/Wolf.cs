using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Products
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine($"{this.GetType().Name} eats {herbivore.GetType().Name} ");
        }
    }
}
