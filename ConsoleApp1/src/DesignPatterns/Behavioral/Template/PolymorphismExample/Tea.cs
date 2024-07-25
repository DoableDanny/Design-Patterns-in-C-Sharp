using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Template.PolymorphismExample
{
    public class Tea : Beverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            System.Console.WriteLine("Brewing tea for 3 minutes");
        }

        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
                System.Console.WriteLine("Adding lemon to tea");
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like lemon with your tea? (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }
}