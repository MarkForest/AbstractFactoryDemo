using ConsoleApp1.Clints;
using ConsoleApp1.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld world = new AnimalWorld(new AfricaFactory());
            world.RunFoodChain();
            Console.WriteLine("===================");
            world = new AnimalWorld(new AmericaFactory());
            world.RunFoodChain();

            Console.ReadKey();
        }
    }
}
