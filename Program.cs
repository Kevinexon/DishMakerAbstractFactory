using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishMakerAbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new CheeseSandwich();
            sandwich.GetRecipe();

            Console.WriteLine();

            var pizza = new MargheritaPizza();
            pizza.GetRecipe();

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }

    
}
