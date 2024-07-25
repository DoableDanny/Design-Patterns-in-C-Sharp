using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Template.PolymorphismExample
{
    public class Coffee : Beverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            System.Console.WriteLine("Brewing coffee for 5 minutes");
        }

        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
                System.Console.WriteLine("Adding cream to coffee");
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like cream with your coffee? (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }
}